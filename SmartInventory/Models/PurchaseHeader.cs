namespace SmartInventory.Models
{
    public class PurchaseHeader
    {
        public string PurchaseCode { get; set; } = string.Empty;
        public string InvoiceNo { get; set; }= string.Empty;
        public string SupplierCode { get; set; } = string.Empty;
        public string SupplierName { get; set; } = String.Empty;
        public string SupplierAddress { get; set; } = string.Empty;
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalPurchases => PurchaseDetails.Sum(detail => detail.PurchasePrice);
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public List<PurchaseDetail> PurchaseDetails { get; set; } = [];
    }
}
