namespace SmartInventory.Models
{
    public class Category : BaseModel
    {
        public string CategoryCode { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public int Padding {  get; set; }
        public int NextNo {  get; set; }
    }
}
