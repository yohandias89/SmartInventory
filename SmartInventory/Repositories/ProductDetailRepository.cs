using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using System.Data;

namespace SmartInventory.Repositories
{
    public static class ProductDetailRepository
    {
        public static List<ProductDetail> GetProductDetails()
        {
            List<ProductDetail> productDetails = [];
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select BarcodeNo, ProductCode, ProductBatch, SupplierCode, ManufactureDate, ExpiryDate, UnitCode, CostPrice,SellingPrice, AvailableQty, Status,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy 
                             from ProductDetail where Status = 1";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                productDetails.Add(new ProductDetail
                {
                    BarcodeNo = reader.GetInt64("BarcodeNo"),
                    ProductCode = reader.GetString("ProductCode"),
                    ProductBatch = reader.GetString("ProductBatch"),
                    SupplierCode = reader.GetString("SupplierCode"),
                    ManufactureDate = DateOnly.FromDateTime(reader.GetDateTime("ManufactureDate")),
                    ExpiryDate = DateOnly.FromDateTime(reader.GetDateTime("ExpiryDate")),
                    UnitCode = reader.GetString("UnitCode"),
                    CostPrice = reader.GetDecimal("CostPrice"),
                    SellingPrice = reader.GetDecimal("SellingPrice"),
                    AvailableQty = reader.GetDecimal("AvailableQty"),
                    Status = reader.GetByte("Status"),
                    CreatedAt = reader.GetDateTime("CreatedAt"),
                    CreatedBy = reader.GetString("CreatedBy"),
                    UpdatedAt = reader.GetDateTime("UpdatedAt"),
                    UpdatedBy = reader.GetString("UpdatedBy")
                });
            }

            return productDetails;

        }

        public static ProductDetail GetProduct(long barcode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select BarcodeNo, ProductCode, ProductBatch, SupplierCode, ManufactureDate, ExpiryDate, UnitCode, CostPrice,SellingPrice, AvailableQty, Status,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy 
                             from ProductDetail where Status = 1 and BarcodeNo = @BarcodeNo";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@BarcodeNo", SqlDbType.Int).Value = barcode;
            using var reader = cmd.ExecuteReader();
            return new ProductDetail
            {
                BarcodeNo = reader.GetInt64("BarcodeNo"),
                ProductCode = reader.GetString("ProductCode"),
                ProductBatch = reader.GetString("ProductBatch"),
                SupplierCode = reader.GetString("SupplierCode"),
                ManufactureDate = DateOnly.FromDateTime(reader.GetDateTime("ManufactureDate")),
                ExpiryDate = DateOnly.FromDateTime(reader.GetDateTime("ExpiryDate")),
                UnitCode = reader.GetString("UnitCode"),
                CostPrice = reader.GetDecimal("CostPrice"),
                SellingPrice = reader.GetDecimal("SellingPrice"),
                AvailableQty = reader.GetDecimal("AvailableQty"),
                Status = reader.GetByte("Status"),
                CreatedAt = reader.GetDateTime("CreatedAt"),
                CreatedBy = reader.GetString("CreatedBy"),
                UpdatedAt = reader.GetDateTime("UpdatedAt"),
                UpdatedBy = reader.GetString("UpdatedBy")
            };

        }

        public static bool CreateProductDetail(ProductDetail productDetail)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"insert into ProductDetail (BarcodeNo, ProductCode, ProductBatch, SupplierCode, ManufactureDate, ExpiryDate, UnitCode, CostPrice,SellingPrice, AvailableQty, Status,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy)
                               values(@BarcodeNo, @ProductCode, @ProductBatch, @SupplierCode, @ManufactureDate, @ExpiryDate, @UnitCode, @CostPrice,@SellingPrice, @AvailableQty, @Status,@CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@BarcodeNo", SqlDbType.Int).Value = productDetail.BarcodeNo;
            cmd.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = productDetail.ProductCode;
            cmd.Parameters.Add("@ProductBatch", SqlDbType.VarChar).Value = productDetail.ProductBatch;
            cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar).Value = productDetail.SupplierCode;
            cmd.Parameters.Add("@ManufactureDate", SqlDbType.Date).Value = productDetail.ManufactureDate;
            cmd.Parameters.Add("@ExpiryDate", SqlDbType.Date).Value = productDetail.ExpiryDate;
            cmd.Parameters.Add("@UnitCode", SqlDbType.VarChar).Value = productDetail.UnitCode;
            cmd.Parameters.Add("@CostPrice", SqlDbType.Decimal).Value = productDetail.CostPrice;
            cmd.Parameters.Add("@SellingPrice", SqlDbType.Decimal).Value = productDetail.SellingPrice;
            cmd.Parameters.Add("@AvailableQty", SqlDbType.Decimal).Value = productDetail.AvailableQty;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = productDetail.Status;
            cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = productDetail.CreatedAt;
            cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = productDetail.CreatedBy;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = productDetail.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = productDetail.UpdatedBy;

            return true;

        }

        public static bool UpdateProductDetail(ProductDetailUpdateModel productDetail)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"update ProductDetail 
                             set 
                                 SupplierCode = @SupplierCode,
                                 ManufactureDate = @ManufactureDate,
                                 ExpiryDate = @ExpiryDate;
                                 UnitCode =  @UnitCode,
                                 CostPrice = @CostPrice,
                                 SellingPrice = @SellingPrice,
                                 AvailableQty = @AvailableQty,
                                 Status = @Status,
                                 UpdatedAt = @UpdatedAt,
                                 UpdatedBy =  @UpdatedBy
                             where BarcodeNo = @BarcodeNo";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@BarcodeNo", SqlDbType.Int).Value = productDetail.BarcodeNo;
            cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar).Value = productDetail.SupplierCode;
            cmd.Parameters.Add("@ManufactureDate", SqlDbType.Date).Value = productDetail.ManufactureDate;
            cmd.Parameters.Add("@ExpiryDate", SqlDbType.Date).Value = productDetail.ExpiryDate;
            cmd.Parameters.Add("@UnitCode", SqlDbType.VarChar).Value = productDetail.UnitCode;
            cmd.Parameters.Add("@CostPrice", SqlDbType.Decimal).Value = productDetail.CostPrice;
            cmd.Parameters.Add("@SellingPrice", SqlDbType.Decimal).Value = productDetail.SellingPrice;
            cmd.Parameters.Add("@AvailableQty", SqlDbType.Decimal).Value = productDetail.AvailableQty;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = productDetail.Status;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = productDetail.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = productDetail.UpdatedBy;

            return true;
        }

        public static bool DeleteProduct(long barcodeNo)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"update ProductDetail
                                set Status = 0
                            where BarcodeNo = @BarcodeNo ";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@BarcodeNo", SqlDbType.Int).Value = barcodeNo;
            return true;
        }

        public static List<ProductSearchModel> GetProductSearchDetails(
            out int totalRecords,
            int pageSize,
            int currentPage,
            string filterBarcode,
            string filterProductName)
        {
            List<ProductSearchModel> products = new();
            totalRecords = 0;

            using var conn = DatabaseConnection.GetConnection();
            conn.Open();

            var whereClauses = new List<string>();
            var parameters = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(filterBarcode))
            {
                whereClauses.Add("b.BarcodeNo LIKE @BarcodeNo");
                parameters.Add(new SqlParameter("@BarcodeNo", $"%{filterBarcode}%"));
            }

            if (!string.IsNullOrWhiteSpace(filterProductName))
            {
                whereClauses.Add("a.ProductName LIKE @ProductName");
                parameters.Add(new SqlParameter("@ProductName", $"%{filterProductName}%"));
            }

            string whereSql = whereClauses.Count > 0 ? "WHERE " + string.Join(" AND ", whereClauses) : "";

            // Count query
            string countQuery = $@"
                                    SELECT COUNT(*) 
                                    FROM Product AS a
                                    JOIN ProductDetail AS b ON a.ProductCode = b.ProductCode
                                    {whereSql}";

            using (var countCmd = new SqlCommand(countQuery, conn))
            {
                foreach (var param in parameters)
                    countCmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value)); // clone

                totalRecords = (int)countCmd.ExecuteScalar();
            }

            int offset = (currentPage - 1) * pageSize;

            // Data query
            string pagedQuery = $@"
                                    SELECT b.BarcodeNo, b.ProductBatch, a.ProductName, b.ExpiryDate, b.UnitCode, 
                                           b.CostPrice, b.SellingPrice, b.AvailableQty
                                    FROM Product AS a
                                    JOIN ProductDetail AS b ON a.ProductCode = b.ProductCode
                                    {whereSql}
                                    ORDER BY b.BarcodeNo
                                    OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

            using var cmd = new SqlCommand(pagedQuery, conn);
            foreach (var param in parameters)
                cmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value)); // clone again

            cmd.Parameters.AddWithValue("@Offset", offset);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                products.Add(new ProductSearchModel
                {
                    BarcodeNo = reader.GetInt32(reader.GetOrdinal("BarcodeNo")),
                    ProductBatch = reader.GetString(reader.GetOrdinal("ProductBatch")),
                    ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                    ExpiryDate = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("ExpiryDate"))),
                    UnitCode = reader.GetString(reader.GetOrdinal("UnitCode")),
                    CostPrice = reader.GetDecimal(reader.GetOrdinal("CostPrice")),
                    SellingPrice = reader.GetDecimal(reader.GetOrdinal("SellingPrice")),
                    AvailableQty = reader.GetDecimal(reader.GetOrdinal("AvailableQty"))
                });
            }

            return products;
        }


    }
}