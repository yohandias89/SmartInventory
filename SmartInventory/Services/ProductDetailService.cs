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


        public static List<ProductSearchModel> GetProductsSearchDetails(
            out int totalRecords,
            out int totalPages,
            int pageSize,
            int currentPage,
            string filterBarcode,
            string filterProductName)
        {
            var products = ProductDetailRepository.GetProductSearchDetails(
                out totalRecords,
                pageSize,
                currentPage,
                filterBarcode,
                filterProductName);

            totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
            return products;
        }
    }


}
