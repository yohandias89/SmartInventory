namespace SmartInventory.DataTransferObjects
{
    public class SubCategoryUpdateModel : BaseModel
    {
        public string CategoryCode { get; set; } = string.Empty;
        public string SubCategoryCode { get; set; } = string.Empty;
        public string SubCategoryName { get; set; } = string.Empty;
    }
}
