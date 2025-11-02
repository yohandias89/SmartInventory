using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Repositories;

namespace SmartInventory.Services
{
    public  class SubCategoryService
    {
        public static List<SubCategory> GetSubCategories()
        {
            return SubcategoryRepository.GetSubCategories();
        }
        public static SubCategory GetSubCategory(string subCategoryCode)
        {
            return SubcategoryRepository.GetCategory(subCategoryCode);
        }

        public static bool CreateSubCategory(SubCategory subCategory)
        {
            return SubcategoryRepository.CreateSubcategory(subCategory);
        }

        public static bool UpdateSubCategory(SubCategoryUpdateModel subCategory)
        {
            return SubcategoryRepository.UpdateSubCategory(subCategory);
        }

        public static bool DeleteSubCategory(string subCategoryCode)
        {
            return SubcategoryRepository.DeleteSubCategory(subCategoryCode);
        }

        public static List<SubCategory> GetSubCategoriesByCategoryCode(string categoryCode)
        {
            return SubcategoryRepository.GetSubCategoriesByCategoryCode(categoryCode);
        }

    }
}
