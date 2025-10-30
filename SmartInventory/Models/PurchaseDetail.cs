

namespace SmartInventory.Models
{
    public class PurchaseDetail
    {
        public string PurchaseCode { get; set; } = string.Empty;
        public int BarcodeNo { get; set; }
        public string BatchNo { get; set; } =string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string UintCode { get; set; } = string.Empty;
        public decimal PurchasePrice { get; set; }
        public decimal PurchaseQty { get; set; }
        public decimal PurchaseAmount { get; set; }
    }
}
