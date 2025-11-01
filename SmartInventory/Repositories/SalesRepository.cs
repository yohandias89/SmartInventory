using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.Models;
using System.Data;

namespace SmartInventory.Repositories
{
    public class SalesRepository
    {
        public static bool CreateSales(SalesHeader salesHeader)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                salesHeader.SalesCode = GenerateSalesCode();

                string createSalesHeaderQuery = @"insert into SalesHeader (SalesCode, CustomerCode, CustomerName,CustomerAddress, CustomerEmail, CustomerContact, PaymentMethod, TotalSales,CreatedAt, CreatedBy)
                                                  values(@SalesCode, @CustomerCode, @CustomerName,@CustomerAddress, @CustomerEmail, @CustomerContact, @PaymentMethod, @TotalSales,@CreatedAt, @CreatedBy)";
                using var headerCmd = new SqlCommand(createSalesHeaderQuery, conn, transaction);
                headerCmd.Parameters.Add("@SalesCode", SqlDbType.VarChar).Value = salesHeader.SalesCode;
                headerCmd.Parameters.Add("@CustomerCode", SqlDbType.VarChar).Value = salesHeader.CustomerCode;
                headerCmd.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = salesHeader.CustomerName;
                headerCmd.Parameters.Add("@CustomerAddress", SqlDbType.VarChar).Value = salesHeader.CustomerAddress;
                headerCmd.Parameters.Add("@CustomerEmail", SqlDbType.VarChar).Value = salesHeader.CustomerEmail;
                headerCmd.Parameters.Add("@CustomerContact", SqlDbType.VarChar).Value = salesHeader.CustomerContact;
                headerCmd.Parameters.Add("@PaymentMethod", SqlDbType.Int).Value = (int)salesHeader.PaymentMethod;
                headerCmd.Parameters.Add("@TotalSales", SqlDbType.Decimal).Value = salesHeader.TotalSales;
                headerCmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = salesHeader.CreatedAt;
                headerCmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = salesHeader.CreatedBy;
                headerCmd.ExecuteNonQuery();
                string createSalesDetailQuery = @"insert into SalesDetail (SalesCode, SequenceNo,BarcodeNo, BatchCode , ProductName,UnitCode,SalesPrice, SalesQty, SalesAmount)
                                                  values(@SalesCode, @SequenceNo,@BarcodeNo, @BatchCode , @ProductName, @UnitCode, @SalesPrice, @SalesQty, @SalesAmount)";
                foreach (var detail in salesHeader.SalesDetails)
                {
                    using var detailCmd = new SqlCommand(createSalesDetailQuery, conn, transaction);
                    detailCmd.Parameters.Add("@SalesCode", SqlDbType.VarChar).Value = salesHeader.SalesCode;
                    detailCmd.Parameters.Add("@SequenceNo", SqlDbType.VarChar).Value = detail.SequenceNo;
                    detailCmd.Parameters.Add("@BarcodeNo", SqlDbType.VarChar).Value = detail.BarcodeNo;
                    detailCmd.Parameters.Add("@BatchCode", SqlDbType.VarChar).Value = detail.BatchCode;
                    detailCmd.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = detail.ProductName;
                    detailCmd.Parameters.Add("@UnitCode", SqlDbType.VarChar).Value = detail.UnitCode;
                    detailCmd.Parameters.Add("@SalesPrice",SqlDbType.Decimal).Value = detail.SalesPrice;
                    detailCmd.Parameters.Add("@SalesQty", SqlDbType.Decimal).Value = detail.SalesQty;
                    detailCmd.Parameters.Add("@SalesAmount", SqlDbType.VarChar).Value = detail.SalesAmount;
                    detailCmd.ExecuteNonQuery();

                    string updateStockQuery = @"update ProductDetail 
                                                set AvailableQty = AvailableQty - @SalesQty,
                                                UpdatedAt = @UpdatedAt,
                                                UpdatedBy = @UpdatedBy
                                                where BarcodeNo = @BarcodeNo";
                    using var stockCmd = new SqlCommand(updateStockQuery, conn, transaction);
                    stockCmd.Parameters.Add("@SalesQty", SqlDbType.Decimal).Value = detail.SalesQty;
                    stockCmd.Parameters.Add("@BarcodeNo", SqlDbType.VarChar).Value = detail.BarcodeNo;
                    stockCmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = DateTime.Now;
                    stockCmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = salesHeader.CreatedBy;

                    stockCmd.ExecuteNonQuery();
                }

                string updateSerialQuery = @"update SerialNumber 
                                                set NextNo = NextNo + 1 
                                                where SerialKey = 'INV'";
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


        public static string GenerateSalesCode()
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();

            string query = @"SELECT SerialKey, Padding, NextNo FROM SerialNumber WHERE SerialKey = 'INV'";
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

            throw new Exception("Serial configuration for 'INV' not found.");
        }
    }
}
