using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Repositories;

namespace SmartInventory.Services
{
    public class ProductDetailService
    {
        public static List<ProductDetail> GetProductDetails()
        {
            return ProductDetailRepository.GetProductDetails();
        }
        public static ProductDetail GetProductDetail(long barcodeNo)
        {
            return ProductDetailRepository.GetProduct(barcodeNo);
        }

        public static bool CreateProductDetail(ProductDetail productDetail)
        {
            return ProductDetailRepository.CreateProductDetail(productDetail);
        }

        public static bool UpdateProductDetail(ProductDetailUpdateModel productDetail)
        {
            return ProductDetailRepository.UpdateProductDetail(productDetail);
        }
        public static bool DeleteProductDetail(long barcodeNo)
        {
            return ProductDetailRepository.DeleteProduct(barcodeNo);
        }
    }
}
