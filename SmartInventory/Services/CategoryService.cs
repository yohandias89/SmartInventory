using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Repositories;

namespace SmartInventory.Services
{
    public  class CategoryService
    {

        public static List<Category> GetCategories()
        {
            return CategoryRepository.Categories();
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

    }
}
