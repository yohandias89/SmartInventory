using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using System.Data;

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
            string query = @"insert into Product (CategoryCode, SubCategoryCode, ProductCode, ProductName, NextBatchNo, Status, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy)
                           values (@CategoryCode, @SubCategoryCode, @ProductCode, @ProductName, @NextBatchNo, @Status, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";
            using var cmd = new SqlCommand(query, conn);
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

            return true;
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
    }
}
