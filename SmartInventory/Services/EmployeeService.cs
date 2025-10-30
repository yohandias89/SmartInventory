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
    }
}
