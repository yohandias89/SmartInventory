namespace SmartInventory.Models
{
    public class Product :BaseModel
    {
        public string CategoryCode { get; set; } = string.Empty;
        public string SubCategoryCode { get; set; }= string.Empty;
        public string ProductCode { get; set; }=string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public  int NextBatchNo { get; set; }
        public List<ProductDetail> ProductDetails { get; set; } = [];
    }
}
