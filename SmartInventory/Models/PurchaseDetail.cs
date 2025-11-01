

namespace SmartInventory.Models
{
    public class PurchaseDetail
    {
        public int SequenceNo { get; set; }
        public string PurchaseCode { get; set; } = string.Empty;
        public int BarcodeNo { get; set; }
        public string BatchCode { get; set; } =string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string UintCode { get; set; } = string.Empty;
        public decimal PurchasePrice { get; set; }
        public decimal PurchaseQty { get; set; }
        public decimal PurchaseAmount => PurchasePrice * PurchaseQty;
    }
}
