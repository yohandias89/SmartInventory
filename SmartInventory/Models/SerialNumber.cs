namespace SmartInventory.Models
{
    public class SerialNumber : BaseModel
    {
        public string SerialKey { get; set; } = string.Empty;
        public string SerialName { get; set; } = string.Empty;
        public int Padding { get; set; }
        public int NextNo{ get; set; }
    }
}
