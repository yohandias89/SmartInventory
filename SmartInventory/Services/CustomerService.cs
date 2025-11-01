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

        public static string GenerateCustomerCode()
        {
            return CustomerRepository.GetNewCustomerCode();
        }

        public static List<CustomerSearchModel> GetCustomerSearchDetails(
           out int totalRecords,
           int pageSize,
           int currentPage,
           string filterFirstName,
           string filterLastName,
           string filterNIC,
           string filterEmail,
           string filterContact
        )
        {
            return CustomerRepository.GetSerchedCustomers(
                out totalRecords,
                pageSize,
                currentPage,
                filterFirstName,
                filterLastName,
                filterNIC,
                filterEmail,
                filterContact
            );
        }

    }
}
