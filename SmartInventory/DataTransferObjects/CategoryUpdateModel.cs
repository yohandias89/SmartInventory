namespace SmartInventory.DataTransferObjects
{
    public class CategoryUpdateModel :BaseModel
    {
        public string CategoryCode { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public int Padding { get; set; } = 5;
        public int NextNo { get; set; } = 1;
    }
}
