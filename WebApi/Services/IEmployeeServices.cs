using WebApi.Models;

namespace WebApi.Services
{
    public interface IEmployeeServices
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int AddEmployee(Employee emp);
        int UpdateEmployee(Employee emp);
        int DeleteEmployee(int id);
    }
}
