namespace SmartInventory.DataTransferObjects
{
    public class ProductDetailUpdateModel : BaseModel
    {
        public long BarcodeNo { get; set; }
        public string SupplierCode { get; set; } = string.Empty;
        public DateOnly? ManufactureDate { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public string UnitCode { get; set; } = string.Empty;
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal AvailableQty { get; set; } = decimal.Zero;
    }
}
