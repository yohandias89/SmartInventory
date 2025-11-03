using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Repositories;

namespace SmartInventory.Services
{
    public  class CategoryService
    {

        public static List<Category> GetCategories()
        {
            return CategoryRepository.GetCategories();
        }

        public static Category GetCategory(string categoryCode)
        {
            return CategoryRepository.GetCategory(categoryCode);
        }

        public static bool CreateCategory(Category category)
        {
            return CategoryRepository.CreateCategory(category);
        }

        public static bool CategoryUpdate(CategoryUpdateModel category)
        {
            return CategoryRepository.UpdateCategory(category);
        }

        public static bool DeleteCategory(string categoryCode)
        {
            return CategoryRepository.DeleteCategory(categoryCode);
        }

        public static bool IsCategoryCodeExists(string categoryCode)
        {
            return CategoryRepository.IsCategoryCodeExists(categoryCode);
        }
        public static List<Category> GetPaginatedCategories(
            out int totalRecords, 
            out int totalPages,
            int pageSize,
            int currentPage
            )
        {
            var categories = CategoryRepository.GetPaginatedCategories(
                out totalRecords,
                pageSize,
                currentPage
                );
            totalPages = (int)System.Math.Ceiling((double)totalRecords / pageSize);
            return categories;
        }

    }
}
