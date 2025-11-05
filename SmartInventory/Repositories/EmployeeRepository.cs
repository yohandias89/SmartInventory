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
            using var transaction = conn.BeginTransaction();
            try
            {
                string createQuery = @"insert into Employee 
                (EmployeeCode, FirstName, LastName, DateOfBirth, NIC, Address, Email, Contact, Status ,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy) 
                values 
                (@EmployeeCode, @FirstName, @LastName, @DateOfBirth, @NIC, @Address, @Email, @Contact, @Status ,@CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";
                var cmd = new SqlCommand(createQuery, conn, transaction);
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

                string updateSerialQuery = @"update SerialNumber 
                                        set NextNo = NextNo + 1 
                                        where SerialKey = 'EMP'";
                var serialCmd = new SqlCommand(updateSerialQuery, conn, transaction);
                serialCmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch(Exception)
            {
                transaction.Rollback();
                throw new Exception("Transaction failed!");
            }

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
                Email = @Email,
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

        public static string GetEmployeeCode()
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();

            string query = @"SELECT SerialKey, Padding, NextNo FROM SerialNumber WHERE SerialKey = 'EMP'";
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

            throw new Exception("Serial configuration for 'EMP' not found.");

        }

        public static List<Employee> GetPaginatedEmployees(
            out int totalRecords, 
            int pageSize, 
            int currentPage,
            string filterFirstName,
            string filterLastName,
            string filterNIC,
            string filterEmail,
            string filterContact)
        {
            List<Employee> employees = [];
            var whereClauses = new List<String>();
            var parameters = new List<SqlParameter>();
            totalRecords = 0;

            

            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            if (!string.IsNullOrEmpty(filterFirstName))
            {
                whereClauses.Add("FirstName LIKE @FirstName");
                parameters.Add(new SqlParameter("@FirstName", $"%{filterFirstName}%"));
            }
            if (!string.IsNullOrEmpty(filterLastName))
            {
                whereClauses.Add("LastName LIKE @LastName");
                parameters.Add(new SqlParameter("@LastName", $"%{filterLastName}%"));
            }
            if (!string.IsNullOrEmpty(filterNIC))
            {
                whereClauses.Add("NIC LIKE @NIC");
                parameters.Add(new SqlParameter("@NIC", $"%{filterNIC}%"));
            }
            if (!string.IsNullOrEmpty(filterEmail))
            {
                whereClauses.Add("Email LIKE @Email");
                parameters.Add(new SqlParameter("@Email", $"%{filterEmail}%"));
            }
            if (!string.IsNullOrEmpty(filterContact))
            {
                whereClauses.Add("Contact LIKE @Contact");
                parameters.Add(new SqlParameter("@Contact", $"%{filterContact}%"));
            }
            string whereClause = whereClauses.Count > 0 ? "WHERE " + string.Join(" AND ", whereClauses) : "";
            string countQuery = $@"SELECT COUNT(*)
                                FROM Employee 
                                {whereClause}";
            using var countCmd = new SqlCommand(countQuery, conn);
            foreach (var param in parameters)
            {
                countCmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value));
            }

            totalRecords = (int)countCmd.ExecuteScalar();

            int offset = (currentPage - 1) * pageSize;

            string pagedQuery = $@"
                SELECT EmployeeCode, FirstName, LastName, DateOfBirth, NIC, Address, Email, Contact, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy
                FROM Employee
                {whereClause}
                ORDER BY EmployeeCode
                OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

            using var cmd = new SqlCommand(pagedQuery, conn);
            foreach (var param in parameters)
            {
                cmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value));
            }
            cmd.Parameters.Add("@Offset", SqlDbType.Int).Value = offset;
            cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                employees.Add(new Employee
                {
                    EmployeeCode = reader.GetString("EmployeeCode"),
                    FirstName = reader.GetString("FirstName"),
                    LastName = reader.GetString("LastName"),
                    DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("DateOfBirth")),
                    NIC = reader.GetString("NIC"),
                    Address = reader.GetString("Address"),
                    Email = reader.GetString("Email"),
                    Contact = reader.GetString("Contact"),
                    CreatedAt = reader.GetDateTime("CreatedAt"),
                    CreatedBy = reader.GetString("CreatedBY"),
                    UpdatedAt = reader.GetDateTime("UpdatedAt"),
                    UpdatedBy = reader.GetString("UpdatedBy")

                });
            }
            return employees;
        }

        public static bool IsExistingNIC (string nic)
        {
            var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"SELECT COUNT(*) FROM Employee WHERE NIC = @NIC";
            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@NIC", SqlDbType.VarChar).Value = nic;
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        public static bool IsExistingEmail(string email)
        {
            var conn = DatabaseConnection.GetConnection(); 
            conn.Open();
            string query = @"SELECT COUNT(*) FROM Employee WHERE Email = @Email;";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
            int count = (int)cmd.ExecuteScalar();
            return count > 0;

        }

        public static bool IsExistingContact(string contact)
        {
            var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"SELECT COUNT(*) FROM Employee WHERE Contact = @Contact;";
            using var cmd =new SqlCommand(query, conn);
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar).Value = contact;
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
    }
}
