using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using System.Data;

namespace SmartInventory.Repositories
{
    public class SubcategoryRepository
    {
        public static List<SubCategory> GetSubCategories()
        {
            List<SubCategory> subCategories = [];

            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select CategoryCode, SubCategoryCode, SubCategoryName, Status, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy from SubCategory
                            where Status = 1";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                subCategories.Add(new SubCategory
                {
                    CategoryCode = reader.GetString("CategoryCode"),
                    SubCategoryCode = reader.GetString("SubCategoryCode"),
                    SubCategoryName = reader.GetString("SubCategoryName"),
                    Status = reader.GetByte("status"),
                    CreatedAt = reader.GetDateTime("CreatedAt"),
                    CreatedBy = reader.GetString("CreatedBy"),
                    UpdatedAt = reader.GetDateTime("UpdatedAt"),
                    UpdatedBy = reader.GetString("UpdatedBy")
                });
            }
            return subCategories;
        }

        public static SubCategory GetCategory(string subCategoryCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select CategoryCode, SubCategoryCode, SubCategoryName, Status, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy from SubCategory
                            where Status = 1 and SubcategoryCode = @SubCategoryCode";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@ubCategoryCode",SqlDbType.VarChar, 8).Value = subCategoryCode;
            using var reader = cmd.ExecuteReader();
            reader.Read();
            return new SubCategory
            {
                CategoryCode = reader.GetString("CategoryCode"),
                SubCategoryCode = reader.GetString("SubCategoryCode"),
                SubCategoryName = reader.GetString("SubCategoryName"),
                Status = reader.GetByte("status"),
                CreatedAt = reader.GetDateTime("CreatedAt"),
                CreatedBy = reader.GetString("CreatedBy"),
                UpdatedAt = reader.GetDateTime("UpdatedAt"),
                UpdatedBy = reader.GetString("UpdatedBy")

            };
        }

        public static bool CreateSubcategory(SubCategory subCategory)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"insert into Subcategory (CategoryCode, SubCategoryCode, SubCategoryName, Status, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy )
                             Values (@CategoryCode, @SubCategoryCode, @SubCategoryName, @Status, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy)";

            using var cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@CategoryCode", SqlDbType.VarChar).Value = subCategory.CategoryCode;
            cmd.Parameters.Add("@SubCategoryCode", SqlDbType.VarChar).Value = subCategory.SubCategoryCode;
            cmd.Parameters.Add("@SubCategoryName", SqlDbType.VarChar).Value = subCategory.SubCategoryName;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = subCategory.Status;
            cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = subCategory.CreatedAt;
            cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = subCategory.CreatedBy;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = subCategory.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = subCategory.UpdatedBy;
            cmd.ExecuteNonQuery();
            return true;
        }

        public static bool UpdateSubCategory(SubCategoryUpdateModel subCategory)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"Update SubCategory 
                            Set CategoryCode = @CategoryCode,
                            SubCategoryCode = @SubCategoryCode,
                            SubCategoryName = @SubCategoryName,
                            Status = @Status,
                            UpdatedAt = @UpdatedAt,
                            UpdatedBy = @UpdatedBy 
                            where Status = 1 and SubcategoryCode = @SubCategoryCode";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@CategoryCode",SqlDbType.VarChar).Value = subCategory.CategoryCode;
            cmd.Parameters.Add("@SubCategoryCode", SqlDbType.VarChar).Value = subCategory.SubCategoryCode;
            cmd.Parameters.Add("@SubCategoryName", SqlDbType.VarChar).Value = subCategory.SubCategoryName;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = subCategory.Status;
            cmd.Parameters.Add("@UpdatedAt", SqlDbType.DateTime).Value = subCategory.UpdatedAt;
            cmd.Parameters.Add("@UpdatedBy", SqlDbType.VarChar).Value = subCategory.UpdatedBy;
            cmd.ExecuteNonQuery();

            return true;
        }

        public static bool DeleteSubCategory(string subCategoryCode)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"update SubCategory
                            set Status = 0 
                            Where Status = 1 and SubCategoryCode = @SubCategoryCode";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@SubCategoryCode", SqlDbType.VarChar).Value = subCategoryCode;
            cmd.ExecuteNonQuery();
            return true;
        }

        public static List<SubCategory> GetSubCategoriesByCategoryCode(string categoryCode)
        {
            List<SubCategory> subCategories = [];
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            string query = @"select CategoryCode, SubCategoryCode, SubCategoryName, Status, CreatedAt, CreatedBy, UpdatedAt, UpdatedBy from SubCategory
                            where Status = 1 and CategoryCode = @CategoryCode";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@CategoryCode", SqlDbType.VarChar).Value = categoryCode;
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                subCategories.Add(new SubCategory
                {
                    CategoryCode = reader.GetString("CategoryCode"),
                    SubCategoryCode = reader.GetString("SubCategoryCode"),
                    SubCategoryName = reader.GetString("SubCategoryName"),
                    Status = reader.GetByte("status"),
                    CreatedAt = reader.GetDateTime("CreatedAt"),
                    CreatedBy = reader.GetString("CreatedBy"),
                    UpdatedAt = reader.GetDateTime("UpdatedAt"),
                    UpdatedBy = reader.GetString("UpdatedBy")
                });
            }
            return subCategories;
        }
    }
}
