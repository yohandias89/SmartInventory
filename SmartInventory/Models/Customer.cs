

namespace SmartInventory.Models
{
    public class Customer : BaseModel
    {
        public string CustomerCode { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }= string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public string NIC { get; set; } = string.Empty;
        public string Address { get; set; }=string.Empty;
        public string Email { get; set; }=string.Empty ;
        public string Contact { get; set; } = string.Empty;
    }
}
