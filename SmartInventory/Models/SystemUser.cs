namespace SmartInventory.Models
{
    public class SystemUser : BaseModel
    {
        public string UserCode { get; set; } = string.Empty;
        public UserRole RoleId { get; set; }
        public string UserName { get; set; }= string.Empty;
        public string Password { get; set; }=string.Empty;

    }
}
