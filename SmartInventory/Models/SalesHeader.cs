namespace SmartInventory.Models
{
    public class SalesHeader
    {
        public string SalesCode { get; set; }   = string.Empty;
        public string CustomerCode { get; set; }= string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerAddress { get; set; }=string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerContact { get; set; }=string.Empty;
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalSales => SalesDetails.Sum(detail => detail.SalesAmount);
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;

        public List<SalesDetail> SalesDetails { get; set; } = [];
    }
}
