using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.Models;

namespace SmartInventory.Repositories
{
    public class PurchaseRepository
    {

        public static bool CreatePurchase(PurchaseHeader purchase)
        {
            purchase.PurchaseCode = GetNePurchaseCode();
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            var transaction = conn.BeginTransaction();
            try
            {
                string createHeaderQuery = @"insert into PurchaseHeader 
                (PurchaseCode, InvoiceNo, SupplierCode, SupplierName, SupplierAddress,Remarks ,PaymentMethod, TotalPurchases, CreatedAt, CreatedBy) 
                values 
                (@PurchaseCode, @InvoiceNo, @SupplierCode, @SupplierName, @SupplierAddress,@Remarks, @PaymentMethod, @TotalPurchases, @CreatedAt, @CreatedBy)";
                using var headerCmd = new SqlCommand(createHeaderQuery, conn, transaction);
                headerCmd.Parameters.Add("@PurchaseCode", System.Data.SqlDbType.VarChar).Value = purchase.PurchaseCode;
                headerCmd.Parameters.Add("@InvoiceNo", System.Data.SqlDbType.VarChar).Value = purchase.InvoiceNo;
                headerCmd.Parameters.Add("@SupplierCode", System.Data.SqlDbType.VarChar).Value = purchase.SupplierCode;
                headerCmd.Parameters.Add("@SupplierName", System.Data.SqlDbType.VarChar).Value = purchase.SupplierName;
                headerCmd.Parameters.Add("@SupplierAddress", System.Data.SqlDbType.VarChar).Value = purchase.SupplierAddress;
                headerCmd.Parameters.Add("@Remarks", System.Data.SqlDbType.VarChar).Value = purchase.Remarks;
                headerCmd.Parameters.Add("@PaymentMethod", System.Data.SqlDbType.TinyInt).Value = (byte)purchase.PaymentMethod;
                headerCmd.Parameters.Add("@TotalPurchases", System.Data.SqlDbType.Decimal).Value = purchase.TotalPurchases;
                headerCmd.Parameters.Add("@CreatedAt", System.Data.SqlDbType.DateTime).Value = purchase.CreatedAt;
                headerCmd.Parameters.Add("@CreatedBy", System.Data.SqlDbType.VarChar).Value = purchase.CreatedBy;
                headerCmd.ExecuteNonQuery();
                string createDetailQuery = @"insert into PurchaseDetail 
                (SequenceNo, PurchaseCode, BarcodeNo, ProductName,BatchCode,UnitCode,PurchasePrice, PurchaseQty,PurchaseAmount ) 
                values 
                (@SequenceNo, @PurchaseCode, @BarcodeNo, @ProductName, @BatchCode, @UnitCode, @PurchasePrice,@PurchaseQty, @PurchaseAmount)";
                foreach (var detail in purchase.PurchaseDetails)
                {
                    using var detailCmd = new SqlCommand(createDetailQuery, conn, transaction);
                    detailCmd.Parameters.Add("@SequenceNo", System.Data.SqlDbType.Int).Value = detail.SequenceNo;
                    detailCmd.Parameters.Add("@PurchaseCode", System.Data.SqlDbType.VarChar).Value = purchase.PurchaseCode;
                    detailCmd.Parameters.Add("@BarcodeNo", System.Data.SqlDbType.VarChar).Value = detail.BarcodeNo;
                    detailCmd.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar).Value = detail.ProductName;
                    detailCmd.Parameters.Add("@BatchCode", System.Data.SqlDbType.VarChar).Value = detail.BatchCode;
                    detailCmd.Parameters.Add("@UnitCode", System.Data.SqlDbType.VarChar).Value = detail.UintCode;
                    detailCmd.Parameters.Add("@PurchasePrice", System.Data.SqlDbType.Decimal).Value = detail.PurchasePrice;
                    detailCmd.Parameters.Add("@PurchaseQty", System.Data.SqlDbType.Decimal).Value = detail.PurchaseQty;
                    detailCmd.Parameters.Add("@PurchaseAmount", System.Data.SqlDbType.Decimal).Value = detail.PurchaseAmount;
                    detailCmd.ExecuteNonQuery();

                    string updateStockQuery = @"update ProductDetail
                                            set AvailableQty = AvailableQty + @PurchaseQty, 
                                                UpdatedAt = @UpdatedAt, 
                                                UpdatedBy = @UpdatedBy 
                                            where BarcodeNo = @BarcodeNo";
                    using var stockCmd = new SqlCommand(updateStockQuery, conn, transaction);
                    stockCmd.Parameters.Add("@PurchaseQty", System.Data.SqlDbType.Decimal).Value = detail.PurchaseQty;
                    stockCmd.Parameters.Add("@UpdatedAt", System.Data.SqlDbType.DateTime).Value = purchase.CreatedAt;
                    stockCmd.Parameters.Add("@UpdatedBy", System.Data.SqlDbType.VarChar).Value = purchase.CreatedBy;
                    stockCmd.Parameters.Add("@BarcodeNo", System.Data.SqlDbType.VarChar).Value = detail.BarcodeNo;
                    stockCmd.ExecuteNonQuery();


                }

                string updateSerialQuery = @"update SerialNumber 
                                            set NextNo = NextNo + 1 
                                            where SerialKey = 'PUR'";
                using var serialCmd = new SqlCommand(updateSerialQuery, conn, transaction);
                serialCmd.ExecuteNonQuery();
                transaction.Commit();
                return true;

            }
            catch (Exception)
            {
                transaction.Rollback();
               throw;
            }
        }

        public static string GetNePurchaseCode()
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();

            string query = @"SELECT SerialKey, Padding, NextNo FROM SerialNumber WHERE SerialKey = 'PUR'";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string serialKey = reader["SerialKey"].ToString()!;
                int padding = Convert.ToInt32(reader["Padding"]);
                int nextNo = Convert.ToInt32(reader["NextNo"]);

                string paddedNumber = nextNo.ToString().PadLeft(padding, '0');
                return $"{serialKey}{paddedNumber}";
            }

            throw new Exception("Serial configuration for 'PUR' not found.");

        }
    }
}
