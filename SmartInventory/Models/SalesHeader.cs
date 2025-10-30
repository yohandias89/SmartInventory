namespace SmartInventory.Models
{
    internal class SalesHeader
    {
        public string SalesCode { get; set; }   = string.Empty;
        public string CustomerCode { get; set; }= string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerContact { get; set; }=string.Empty;
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalSales { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
    }
}
