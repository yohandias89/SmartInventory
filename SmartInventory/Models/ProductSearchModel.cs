namespace SmartInventory.Models
{
    public class ProductSearchModel
    {
        public int BarcodeNo { get; set; }
        public string ProductBatch { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public DateOnly? ExpiryDate { get; set; }
        public string UnitCode { get; set; } = string.Empty;
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal AvailableQty { get; set; } = decimal.Zero;
    }
}
