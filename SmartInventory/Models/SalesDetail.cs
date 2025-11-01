namespace SmartInventory.Models
{
    public class SalesDetail
    {
        public string SalesCode { get; set; } = string.Empty;
        public int SequenceNo { get; set; }
        public int BarcodeNo { get; set; }
        public string BatchCode { get; set; }= string.Empty;

        public string ProductName { get; set; } = string.Empty;
        public string UnitCode { get; set; } = string.Empty;
        public decimal SalesPrice { get; set; }
        public decimal SalesQty { get; set; }
        public decimal SalesAmount => SalesPrice * SalesQty;

    }
}
