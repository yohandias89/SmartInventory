using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using System.Data;

namespace SmartInventory.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = [];
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select EmployeeCode, FirstName, LastName, DateOfBirth, NIC, Address, Email, Contact, Status ,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy  
                             from Employee where Status = 1";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                employees.Add(new Employee
                {
                    EmployeeCode = reader.GetString("employeeCode"),
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
                });
            }
            return employees;

        }

        public static Employee GetEmployee(string employeeCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select EmployeeCode, FirstName, LastName, DateOfBirth, NIC, Address, Email, Contact, Status ,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy  
                            from employee where Status = 1 and employeeCode = @EmployeeCode";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeCode", SqlDbType.VarChar).Value = employeeCode;
            using var reader = cmd.ExecuteReader();
            return new Employee
            {
                EmployeeCode = reader.GetString("EmployeeCode"),
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

        public static bool CreateEmployee(Employee employee)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"insert into employee (EmployeeCode, FirstName, LastName, DateOfBirth, NIC, Address, Email, Contact, Status ,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy)
                             values (@EmployeeCode, @FirstName, @LastName, @DateOfBirth, @NIC, @Address, @Email, @Contact, @Status ,@CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@EmployeeCode", SqlDbType.VarChar).Value = employee.EmployeeCode;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = employee.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = employee.LastName;
            cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = employee.DateOfBirth;
            cmd.Parameters.Add("@NIC", SqlDbType.VarChar).Value = employee.NIC;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = employee.Address;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = employee.Email;
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = employee.Contact;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = employee.Status;
            cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = employee.CreatedAt;
            cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = employee.CreatedBy;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = employee.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = employee.UpdatedBy;
            cmd.ExecuteNonQuery();

            return true;

        }

        public static bool UpdateEmployee(EmployeeUpdateModel employee)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"update Employee 
                set 
                FirstName = @FirstName,
                LastName = @LastName,
                DateOfBirth = @DateOfBirth,
                NIC = @NIC,
                Address = @Address,
                Email @Email,
                Contact = @Contact,
                Status  = @Status ,
                UpdatedAt = @UpdatedAt,
                UpdatedBy = @UpdatedBy
                where EmployeeCode = @EmployeeCode";

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@EmployeeCode", SqlDbType.VarChar).Value = employee.EmployeeCode;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = employee.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = employee.LastName;
            cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = employee.DateOfBirth;
            cmd.Parameters.Add("@NIC", SqlDbType.VarChar).Value = employee.NIC;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = employee.Address;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = employee.Email;
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = employee.Contact;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = employee.Status;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = employee.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = employee.UpdatedBy;
            cmd.ExecuteNonQuery();

            return true;

        }

        public static bool DeleteEmployee(string employeeCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"update employee
                            set Status = 0
                            where EmployeeCode = @EmployeeCode";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@EmployeeCode", SqlDbType.VarChar).Value = employeeCode;
            cmd.ExecuteNonQuery();

            return true;

        }
    }
}
