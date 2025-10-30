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
                    Status =reader.GetByte(" Status"),
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
            string query = @"insert into Supplier (SupplierCode, SupplierName, ContactPerson, Address, Email, Contact, Status, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy)
                            values(@SupplierCode, @SupplierName, @ContactPerson, @Address, @Email, @Contact, @Status, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";
            using var cmd = new SqlCommand(@query,conn);
            cmd.Parameters.Add("@SupplierCode",SqlDbType.VarChar).Value = supplier.SupplierCode;
            cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = supplier.SupplierName;
            cmd.Parameters.Add("@ContactPerson",SqlDbType.VarChar).Value = supplier.ContactPerson;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value= supplier.Address;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = supplier.Email;
            cmd.Parameters.Add("@Contac", SqlDbType.VarChar).Value = supplier.Contact;
            cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = supplier.CreatedAt;
            cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = supplier.CreatedBy;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value= supplier.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = supplier.UpdatedBy;
            cmd.ExecuteNonQuery();
            return true;
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
                            UpdatedBy = @UpdatedBy ";
            using var cmd = new SqlCommand(@query, conn);
            cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar).Value = supplier.SupplierCode;
            cmd.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = supplier.SupplierName;
            cmd.Parameters.Add("@ContactPerson", SqlDbType.VarChar).Value = supplier.ContactPerson;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = supplier.Address;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = supplier.Email;
            cmd.Parameters.Add("@Contac", SqlDbType.VarChar).Value = supplier.Contact;
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
                            set Status = 0,  
                            where SupplierCode = @SupplierCode ";
            using var cmd = new SqlCommand(@query, conn);
            cmd.Parameters.Add("@SupplierCode", SqlDbType.VarChar).Value = supplierCode;
            cmd.ExecuteNonQuery();

            return true;
        }
    }
}
