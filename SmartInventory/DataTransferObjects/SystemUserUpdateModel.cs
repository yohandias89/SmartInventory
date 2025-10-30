using SmartInventory.Models;

namespace SmartInventory.DataTransferObjects
{
    public class SystemUserUpdateModel :BaseModel
    {
        public string UserCode { get; set; } = string.Empty;
        public UserRole RoleId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
