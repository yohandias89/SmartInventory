

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
    }
}
