using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using System.Data;

namespace SmartInventory.Repositories
{
    public class CustomerRepository
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = [];
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select CustomerCode, FirstName, LastName, DateOfBirth, NIC, Address, Email, Contact, Status ,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy  
                            from Customer where Status = 1";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    CustomerCode = reader.GetString("CustomerCode"),
                    FirstName =reader.GetString("FirstName"),
                    LastName = reader.GetString("LastName"),
                    DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("DateOfBirth")),
                    NIC = reader.GetString("NIC"),
                    Address = reader.GetString("Address"),
                    Email = reader.GetString("Email"),
                    Contact = reader.GetString("Contact"),
                    Status = reader.GetByte("status"),
                    CreatedAt = reader.GetDateTime("CreatedAt"),
                    CreatedBy = reader.GetString("CreatedBy"),
                    UpdatedAt = reader.GetDateTime("UpdatedAt"),
                    UpdatedBy = reader.GetString("UpdatedBy")
                });
            }
            return customers;

        }

        public static Customer GetCustomer(string customerCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select CustomerCode, FirstName, LastName, DateOfBirth, NIC, Address, Email, Contact, Status ,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy  
                             from Customer where Status = 1 and CustomerCode = @CustomerCode";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            return new Customer
            {
                CustomerCode = reader.GetString("CustomerCode"),
                FirstName = reader.GetString("FirstName"),
                LastName = reader.GetString("LastName"),
                DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("DateOfBirth")),
                NIC = reader.GetString("NIC"),
                Address = reader.GetString("Address"),
                Email = reader.GetString("Email"),
                Contact = reader.GetString("Contact"),
                Status = reader.GetByte("status"),
                CreatedAt = reader.GetDateTime("CreatedAt"),
                CreatedBy = reader.GetString("CreatedBy"),
                UpdatedAt = reader.GetDateTime("UpdatedAt"),
                UpdatedBy = reader.GetString("UpdatedBy")
            };
            
        }

        public static bool CreateCustomer(Customer customer)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();

            using var transaction = conn.BeginTransaction();
            try
            {
                string createQuery = @"insert into Customer (CustomerCode, FirstName, LastName, DateOfBirth, NIC, Address, Email, Contact, Status ,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy) 
                             values (@CustomerCode, @FirstName, @LastName, @DateOfBirth, @NIC, @Address, @Email, @Contact, @Status ,@CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";

                var cmd = new SqlCommand(createQuery, conn, transaction);
                cmd.Parameters.Add("@CustomerCode", SqlDbType.VarChar).Value = customer.CustomerCode;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = customer.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = customer.LastName;
                cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = customer.DateOfBirth;
                cmd.Parameters.Add("@NIC", SqlDbType.VarChar).Value = customer.NIC;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = customer.Address;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = customer.Email;
                cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = customer.Contact;
                cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = customer.Status;
                cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = customer.CreatedAt;
                cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = customer.CreatedBy;
                cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = customer.UpdatedAt;
                cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = customer.UpdatedBy;
                cmd.ExecuteNonQuery();

                string updateSerialQuery = @"update SerialNumber 
                                              set NextNo = NextNo + 1 
                                              where SerialKey = 'CUS'";
                var serialCmd = new SqlCommand(updateSerialQuery, conn, transaction);
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

        public static bool UpdateCustomer(CustomerUpdateModel customer)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"update Customer 
                            set  
                            FirstName = @FirstName,
                            LastName = @LastName, 
                            DateOfBirth = @DateOfBirth, 
                            NIC = @NIC, 
                            Address = @Address, 
                            Email = @Email, 
                            Contact = @Contact,
                            Status  = @Status , 
                            UpdatedAt = @UpdatedAt, 
                            UpdatedBy = @UpdatedBy
                            where CustomerCode = @CustomerCode ";

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@CustomerCode", SqlDbType.VarChar).Value = customer.CustomerCode;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = customer.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = customer.LastName;
            cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = customer.DateOfBirth;
            cmd.Parameters.Add("@NIC", SqlDbType.VarChar).Value = customer.NIC;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = customer.Address;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = customer.Email;
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = customer.Contact;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = customer.Status;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = customer.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = customer.UpdatedBy;
            cmd.ExecuteNonQuery();

            return true;

        }

        public static bool DeleteCustomer(string customerCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"update Customer 
                            set Status = 0 
                            where CustomerCode = @CustomerCode";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@CustomerCode", SqlDbType.VarChar).Value = customerCode;
            cmd.ExecuteNonQuery();

            return true;

        }

        public static string GetNewCustomerCode()
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();

            string query = @"SELECT SerialKey, Padding, NextNo FROM SerialNumber WHERE SerialKey = 'CUS'";
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

            throw new Exception("Serial configuration for 'CUS' not found.");

        }
    }
}
