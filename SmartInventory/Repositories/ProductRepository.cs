using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using SmartInventory.Database;
using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using System.Data;
using System.Drawing.Printing;

namespace SmartInventory.Repositories
{
    public  class ProductRepository
    {
        public static List<Product> GetProducts() { 
            List<Product> products = [];
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select CategoryCode, SubCategoryCode, ProductCode, ProductName, NextBatchNo,Status, CreatedAt, CreatedBy,UpdatedAt, UpdatedBy from Product
                            where Status = 1 ";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                products.Add(new Product
                {
                    CategoryCode = reader.GetString("CategoryCode"),
                    SubCategoryCode = reader.GetString("SubCategoryCode"),
                    ProductCode = reader.GetString("ProductCode"),
                    ProductName = reader.GetString("ProductName"),
                    NextBatchNo = reader.GetInt32("NextBatchNo"),
                    Status = reader.GetByte("Status"),
                    CreatedAt = reader.GetDateTime("CreatedAt"),
                    CreatedBy = reader.GetString("CreatedBy"),
                    UpdatedAt = reader.GetDateTime("UpdatedAt"),
                    UpdatedBy = reader.GetString("UpdatedBy")
                });
            }

            return products;
        }

        public static Product GetProduct(string  productCode) {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select CategoryCode, SubCategoryCode, ProductCode, ProductName, NextBatchNo,Status, CreatedAt, CreatedBy,UpdatedAt, UpdatedBy from Product
                             where Status = 1 and ProductCode = @ProductCode ";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            cmd.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = productCode;
            reader.Read();
            return new Product
            {
                CategoryCode = reader.GetString("CategoryCode"),
                SubCategoryCode = reader.GetString("SubCategoryCode"),
                ProductCode = reader.GetString("ProductCode"),
                ProductName = reader.GetString("ProductName"),
                NextBatchNo = reader.GetInt32("NextBatchNo"),
                Status = reader.GetByte("Status"),
                CreatedAt = reader.GetDateTime("CreatedAt"),
                CreatedBy = reader.GetString("CreatedBy"),
                UpdatedAt = reader.GetDateTime("UpdatedAt"),
                UpdatedBy = reader.GetString("UpdatedBy")

            };
        }

        public static bool CreateProduct(Product product)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            var transaction = conn.BeginTransaction();
            try
            {
                string nextProductCode = GetNextProductCode(product.CategoryCode);
                product.ProductCode = nextProductCode;

                string query = @"insert into Product (CategoryCode, SubCategoryCode, ProductCode, ProductName, NextBatchNo, Status, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy)
                           values (@CategoryCode, @SubCategoryCode, @ProductCode, @ProductName, @NextBatchNo, @Status, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";
                using var cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.Add("@CategoryCode", SqlDbType.VarChar).Value = product.CategoryCode;
                cmd.Parameters.Add("@SubCategoryCode", SqlDbType.VarChar).Value = product.SubCategoryCode;
                cmd.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = product.ProductCode;
                cmd.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = product.ProductName;
                cmd.Parameters.Add("@NextBatchNo", SqlDbType.Int).Value = product.NextBatchNo;
                cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = product.Status;
                cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = product.CreatedAt;
                cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = product.CreatedBy;
                cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = product.UpdatedAt;
                cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = product.UpdatedBy;
                cmd.ExecuteNonQuery();

                string updateQuery = @"UPDATE Category SET NextNo = NextNo + 1 WHERE CategoryCode = @CategoryCode";
                using var updateCmd = new SqlCommand(updateQuery, conn, transaction);
                updateCmd.Parameters.Add("@CategoryCode", SqlDbType.VarChar).Value = product.CategoryCode;
                updateCmd.ExecuteNonQuery();

                transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }
 

        public static bool UpdateProduct(ProductUpdateModel product)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"Update Product
                set CategoryCode = @CategoryCode,
                SubCategoryCode = @SubCategoryCode,
                ProductName = @ProductName,
                NextBatchNo = @NextBatchNo,
                Status = @Status,
                UpdatedAt = @UpdatedAt,
                UpdatedBy =@UpdatedBy
                where ProductCode = @ProductCode";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@CategoryCode", SqlDbType.VarChar).Value = product.CategoryCode;
            cmd.Parameters.Add("@SubCategoryCode", SqlDbType.VarChar).Value = product.SubCategoryCode;
            cmd.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = product.ProductCode;
            cmd.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = product.ProductName;
            cmd.Parameters.Add("@NextBatchNo", SqlDbType.Int).Value = product.NextBatchNo;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = product.Status;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = product.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = product.UpdatedBy;
            cmd.ExecuteNonQuery();

            return true;

        }

        public static bool DeleteProduct(string productCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"update product
                            Set Status = 0
                            where ProductCode = @ProductCode";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = productCode;
            cmd.ExecuteNonQuery();
            return true;
        }

        public static string GetNextProductCode(string categoryCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select CategoryCode, Padding, NextNo From Category WHERE Status = 1 and CategoryCode = @CategoryCode";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@CategoryCode", SqlDbType.VarChar).Value = categoryCode;
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                string categoryCodeFromDb = reader.GetString("CategoryCode");
                int padding = reader.GetInt32("Padding");
                int nextNo = reader.GetInt32("NextNo");
                string nextProductCode = categoryCodeFromDb + nextNo.ToString().PadLeft(padding, '0');
                // Update NextNo in Category table
                return nextProductCode;
            }
            else
            {
                throw new Exception("Category not found.");
            }
        }


        public static List<Product> GetSearchedProducts(
            out int totalRecords,
            int pageSize,
            int currentPage,
            string filterCategoryCode,
            string filterSubCategoryCode,
            string filterProductCode,
            string filterProductName
         )
        {
            List<Product> products = [];
            var whereClauses = new List<string>();
            var parameters = new List<SqlParameter>();
            totalRecords = 0;

            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            if (!string.IsNullOrEmpty(filterCategoryCode)) {
                whereClauses.Add("CategoryCode LIKE '%' + @CategoryCode + '%' ");
                parameters.Add(new SqlParameter("@CategoryCode", SqlDbType.VarChar) { Value = filterCategoryCode });
            }
            if (!string.IsNullOrEmpty(filterSubCategoryCode)) {
                whereClauses.Add("SubCategoryCode LIKE '%' + @SubCategoryCode + '%' ");
                parameters.Add(new SqlParameter("@SubCategoryCode", SqlDbType.VarChar) { Value = filterSubCategoryCode });
            }
            if (!string.IsNullOrEmpty(filterProductCode)) {
                whereClauses.Add("ProductCode LIKE '%' + @ProductCode + '%'");
                parameters.Add(new SqlParameter("@ProductCode", SqlDbType.VarChar) { Value = filterProductCode });
            }
            if (!string.IsNullOrEmpty(filterProductName)) {
                whereClauses.Add("ProductName LIKE '%' + @ProductName + '%'");
                parameters.Add(new SqlParameter("@ProductName", SqlDbType.VarChar) { Value = filterProductName });
            }

            string whereClause = whereClauses.Count > 0 ? " AND " + string.Join(" AND ", whereClauses) : string.Empty;
            string countQuery = $"SELECT COUNT(*) FROM Product WHERE Status = 1 {whereClause}";
            using var countCmd = new SqlCommand(countQuery, conn);

            foreach (var param in parameters) {
                countCmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value));
            }

            totalRecords = (int)countCmd.ExecuteScalar();
           

            int offset = (currentPage - 1) * pageSize;
            string pagedQuery = $@"
                SELECT CategoryCode, SubCategoryCode, ProductCode, ProductName, NextBatchNo,Status, CreatedAt, CreatedBy,UpdatedAt, UpdatedBy
                FROM Product
                WHERE Status = 1
                {whereClause}
                ORDER BY ProductName
                OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";
            using var pagedCmd = new SqlCommand(pagedQuery, conn);
            foreach (var param in parameters) {
                pagedCmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value));
            }
            pagedCmd.Parameters.Add("@Offset", SqlDbType.Int).Value = offset;
            pagedCmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
            using var reader = pagedCmd.ExecuteReader();
            while (reader.Read()) {
                products.Add(new Product
                {
                    CategoryCode = reader.GetString("CategoryCode"),
                    SubCategoryCode = reader.GetString("SubCategoryCode"),
                    ProductCode = reader.GetString("ProductCode"),
                    ProductName = reader.GetString("ProductName"),
                    NextBatchNo = reader.GetInt32("NextBatchNo"),
                    Status = reader.GetByte("Status"),
                    CreatedAt = reader.GetDateTime("CreatedAt"),
                    CreatedBy = reader.GetString("CreatedBy"),
                    UpdatedAt = reader.GetDateTime("UpdatedAt"),
                    UpdatedBy = reader.GetString("UpdatedBy")
                });
            }
            return products;
        }
    }
}
