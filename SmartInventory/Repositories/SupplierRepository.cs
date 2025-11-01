using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using System.Data;

namespace SmartInventory.Repositories
{
    public class SupplierRepository
    {
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = [];
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select SupplierCode, SupplierName,ContactPerson, Address, Email, Contact, Status, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy 
                            from Supplier where Status = 1";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                suppliers.Add(new Supplier
                {
                    SupplierCode = reader.GetString("SupplierCode"),
                    SupplierName = reader.GetString("SupplierName"),
                    ContactPerson = reader.GetString("ContactPerson"),
                    Address = reader.GetString("Address"),
                    Email = reader.GetString("Email"),
                    Contact = reader.GetString("Contact"),
                    Status =reader.GetByte("Status"),
                    CreatedAt = reader.GetDateTime("CreatedAt"),
                    CreatedBy = reader.GetString("CreatedBy"),
                    UpdatedAt = reader.GetDateTime("UpdatedAt"),
                    UpdatedBy = reader.GetString("UpdatedBy")
                });
            }
            return suppliers;
        }

        public static Supplier GetSupplier(string supplierCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select SupplierCode, SupplierName,ContactPerson, Address, Email, Contact, Status, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy
                             from Supplier where Status = 1 and SupplierCode = @SupplierCode";
            using var cmd = new SqlCommand(query,conn);
            cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar).Value = supplierCode;
            using var reader = cmd.ExecuteReader();
            return new Supplier
            {
                SupplierCode = reader.GetString("SupplierCode"),
                SupplierName = reader.GetString("SupplierName"),
                ContactPerson = reader.GetString("ContactPerson"),
                Address = reader.GetString("Address"),
                Email = reader.GetString("Email"),
                Contact = reader.GetString("Contact"),
                Status = reader.GetByte(" Status"),
                CreatedAt = reader.GetDateTime("CreatedAt"),
                CreatedBy = reader.GetString("CreatedBy"),
                UpdatedAt = reader.GetDateTime("UpdatedAt"),
                UpdatedBy = reader.GetString("UpdatedBy")
            };
        }

        public static bool CreateSuppler(Supplier supplier)
        {

            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            
            using var transaction = conn.BeginTransaction();
            try
            {
                string createQuery = @"insert into Supplier (SupplierCode, SupplierName, ContactPerson, Address, Email, Contact, Status, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy)
                            values(@SupplierCode, @SupplierName, @ContactPerson, @Address, @Email, @Contact, @Status, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";

                using var cmd = new SqlCommand(createQuery, conn, transaction);
                cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar).Value = supplier.SupplierCode;
                cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = supplier.SupplierName;
                cmd.Parameters.Add("@ContactPerson", SqlDbType.VarChar).Value = supplier.ContactPerson;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = supplier.Address;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = supplier.Email;
                cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = supplier.Contact;
                cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = supplier.Status;
                cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = supplier.CreatedAt;
                cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = supplier.CreatedBy;
                cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = supplier.UpdatedAt;
                cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = supplier.UpdatedBy;
                cmd.ExecuteNonQuery();

                string updateSerialQuery = @"update SerialNumber 
                                            set NextNo = NextNo + 1 
                                            where SerialKey = 'SUP'";
                using var serialCmd = new SqlCommand(updateSerialQuery, conn, transaction);
                serialCmd.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw new Exception("Transaction failed!");
            }
        }

        public static bool UpdateSupplier(SupplierUpdateModel supplier)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"update Supplier 
                            set SupplierCode = @SupplierCode ,
                            SupplierName =  @SupplierName, 
                            ContactPerson = @ContactPerson, 
                            Address = @Address, 
                            Email = @Email, 
                            Contact = @Contact, 
                            Status = @Status,  
                            UpdatedAt = @UpdatedAt, 
                            UpdatedBy = @UpdatedBy 
                            where SupplierCode = @SupplierCode";
            using var cmd = new SqlCommand(@query, conn);
            cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar).Value = supplier.SupplierCode;
            cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = supplier.SupplierName;
            cmd.Parameters.Add("@ContactPerson", SqlDbType.VarChar).Value = supplier.ContactPerson;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = supplier.Address;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = supplier.Email;
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = supplier.Contact;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = supplier.Status;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = supplier.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = supplier.UpdatedBy;
            cmd.ExecuteNonQuery();

            return true;
        }

        public static bool DeleteSupplier(string supplierCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"update Supplier 
                            set Status = 0  
                            where SupplierCode = @SupplierCode ";
            using var cmd = new SqlCommand(@query, conn);
            cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar).Value = supplierCode;
            cmd.ExecuteNonQuery();

            return true;
        }

        public static string GetSupplierCode()
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();

            string query = @"SELECT SerialKey, Padding, NextNo FROM SerialNumber WHERE SerialKey = 'SUP'";
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

            throw new Exception("Serial configuration for 'SUP' not found.");

        }
    }
}
