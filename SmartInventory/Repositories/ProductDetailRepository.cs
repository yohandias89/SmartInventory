using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using System.Data;

namespace SmartInventory.Repositories
{
    public static  class ProductDetailRepository
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
                    CostPrice =reader.GetDecimal("CostPrice"),
                    SellingPrice = reader.GetDecimal("SellingPrice"),
                    AvailableQty = reader.GetDecimal("AvailableQty"),
                    Status = reader.GetByte("Status"),
                    CreatedAt = reader.GetDateTime("CreatedAt"),
                    CreatedBy =reader.GetString("CreatedBy"),
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
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value= productDetail.UpdatedBy;

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

    }
}
