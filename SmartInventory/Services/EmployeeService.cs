using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Repositories;

namespace SmartInventory.Services
{
    public  class EmployeeService
    {
        public static List<Employee> GetEmployees()
        {
            return EmployeeRepository.GetEmployees();
        }

        public static Employee GetEmployee(string employeeCode)
        {
            return EmployeeRepository.GetEmployee(employeeCode);
        }

        public static bool CreateEmployee(Employee employee)
        {
            return EmployeeRepository.CreateEmployee(employee);
        }

        public static bool UpdateEmployee(EmployeeUpdateModel employee)
        {
            return EmployeeRepository.UpdateEmployee(employee);
        }

        public static bool DeleteEmployee(string employeeCode)
        {   
            return EmployeeRepository.DeleteEmployee(employeeCode);
        }

        public static string GetEmployeeCode()
        {
            return EmployeeRepository.GetEmployeeCode();
        }

        public static List<Employee> GetPaginatedEmployees(
            out int totalRecords, 
            out int totalPages, 
            int pageSize,
            int currentPage,
            string filterFirstName,
            string filterLastName,
            string filterNIC,
            string filterEmail,
            string filterContact)
        {

            var employees = EmployeeRepository.GetPaginatedEmployees(

                out totalRecords,
                pageSize,
                currentPage,
                filterFirstName,
                filterLastName,
                filterNIC,
                filterEmail,
                filterContact
                );
            totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
            return employees;
        }

        public static bool IsExistingNIC(string nic)
        {
            return EmployeeRepository.IsExistingNIC(nic);
        }

        public static bool IsExistingEmail(string email)
        {
            return EmployeeRepository.IsExistingEmail(email);
        }

        public static bool IsExistingContact(string contact)
        {
            return EmployeeRepository.IsExistingContact(contact);
        }
    }
}
