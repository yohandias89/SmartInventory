using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Repositories;

namespace SmartInventory.Services
{
    public class CustomerService
    {
        public static List<Customer> GetCustomers()
        {
            return CustomerRepository.GetCustomers();
        }
        public static Customer GetCustomer(string customerCode)
        {
            return CustomerRepository.GetCustomer(customerCode);
        }
        public static bool CreateCustomer(Customer customer)
        {
            return CustomerRepository.CreateCustomer(customer);
        }

        public static bool UpdateCustomer(CustomerUpdateModel customer)
        {
            return CustomerRepository.UpdateCustomer(customer);
        }
        public static bool DeleteCustomer(string customerCode)
        {
            return CustomerRepository.DeleteCustomer(customerCode);
        }
    }
}
