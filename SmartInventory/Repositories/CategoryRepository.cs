using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using System.Data;

namespace SmartInventory.Repositories
{
    public class CategoryRepository
    {
        public static List<Category> Categories()
        {

            List<Category> categories = [];
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select CategoryCode, CategoryName, Padding, NextNo, Status,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy 
                            from category where Status = 1";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                categories.Add(new Category
                {
                    CategoryCode = reader.GetString("CategoryCode"),
                    CategoryName = reader.GetString("CategoryName"),
                    Padding = reader.GetInt32("Padding"),
                    NextNo = reader.GetInt32("NextNo"),
                    Status = reader.GetByte("Status"),
                    CreatedAt = reader.GetDateTime("CreatedAt"),
                    CreatedBy = reader.GetString("CreatedBy"),
                    UpdatedAt = reader.GetDateTime("UpdatedAt"),
                    UpdatedBy = reader.GetString("UpdatedBy")
                });
            }
            return categories;
        }

        public static Category GetCategory(string categoryCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select CategoryCode, CategoryName, Padding, NextNo, Status,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy 
                             from category where Status = 1 and CategoryCode = @CategoryCode";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@CategoryCode", SqlDbType.VarChar).Value = categoryCode;
            using var reader = cmd.ExecuteReader();

            return new Category
            {
                CategoryCode = reader.GetString("CategoryCode"),
                CategoryName = reader.GetString("CategoryName"),
                Padding = reader.GetInt32("Padding"),
                NextNo = reader.GetInt32("NextNo"),
                Status = reader.GetInt32("Status"),
                CreatedAt = reader.GetDateTime("CreatedAt"),
                CreatedBy = reader.GetString("CreatedBy"),
                UpdatedAt = reader.GetDateTime("UpdatedAt"),
                UpdatedBy = reader.GetString("UpdatedBy")
            };

        }

        public static bool CreateCategory(Category category)
        {

            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string insertQuery = @"insert into Category 
                                   (CategoryCode, CategoryName, Padding, NextNo, Status,CreatedAt, CreatedBy, UpdatedAt, UpdatedBy)
                                   values (@CategoryCode, @CategoryName, @Padding, @NextNo, @Status, @CreatedAt, @CreatedBy, @UpdatedAt,@UpdatedBy) ";
            using var cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.Add("@CategoryCode", SqlDbType.VarChar).Value = category.CategoryCode;
            cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = category.CategoryName;
            cmd.Parameters.Add("@Padding", SqlDbType.Int).Value = category.Padding;
            cmd.Parameters.Add("@NextNo", SqlDbType.Int).Value = category.NextNo;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = category.Status;
            cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = category.CreatedAt;
            cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = category.CreatedBy;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = category.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = category.UpdatedBy;
            cmd.ExecuteNonQuery();
            return true;


        }

        public static bool UpdateCategory(CategoryUpdateModel category)
        {

            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string updateQuery = @"update Category 
                                       set CategoryName = @CategoryName,
                                       Padding = @Padding,
                                       NextNo = @NextNo, 
                                       Status = @Status,
                                       UpdatedAt = @UpdatedAt,
                                       UpdatedBy = @UpdatedBy
                                       where CategoryCode = @CategoryCode";

            using var cmd = new SqlCommand(updateQuery, conn);
            cmd.Parameters.Add("@CategoryCode", SqlDbType.VarChar).Value =category.CategoryCode;
            cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = category.CategoryName;
            cmd.Parameters.Add("@Padding", SqlDbType.Int).Value = category.Padding;
            cmd.Parameters.Add("@NextNo", SqlDbType.Int).Value = category.NextNo;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = category.NextNo;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = category.UpdatedBy;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = category.UpdatedAt;
            cmd.ExecuteNonQuery();
            return true;
        }

        public static bool DeleteCategory(string categoryCode)
        {

            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string deleteQuery = @"update Category 
                                       set Status = 0 
                                       where CategoryCode = @CategoryCode";
            using var cmd = new SqlCommand(deleteQuery, conn);
            cmd.Parameters.Add("@CategoryCode", SqlDbType.VarChar).Value = categoryCode;
            cmd.ExecuteNonQuery();
            return true;

        }
    }
}
