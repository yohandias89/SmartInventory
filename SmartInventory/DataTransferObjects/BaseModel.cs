namespace SmartInventory.DataTransferObjects
{
    public class BaseModel
    {
        public int Status { get; set; } = 1;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
    }
}
