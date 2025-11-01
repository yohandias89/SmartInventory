

using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Repositories;

namespace SmartInventory.Services
{
    public class ProductService
    {
        public static List<Product> GetProducts()
        {
            return ProductRepository.GetProducts();
        }
        public static Product GetProduct(string productCode)
        {
            return ProductRepository.GetProduct(productCode);
        }

        public static bool CreateProduct(Product product)
        {
            return ProductRepository.CreateProduct(product);
        }

        public static bool UpdateProduct(ProductUpdateModel product)
        {
            return ProductRepository.UpdateProduct(product);
        }

        public static bool DeleteProduct(string productCode)
        {
            return ProductRepository.DeleteProduct(productCode);
        }

        public  static List<Product> SearchProducts(
            out int totalRecords,
            out int totalPages,
            int pageSize,
            int currentPage,
            string filterCategoryCode,
            string filterSubCategoryCode,
            string filterProductCode,
            string filterProductName
            )
        {
            var products = ProductRepository.GetSearchedProducts(
                out totalRecords,
                pageSize,
                currentPage,
                filterCategoryCode,
                filterSubCategoryCode,
                filterProductCode,
                filterProductName
                );
            totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
            return products;
        }
    }
}
