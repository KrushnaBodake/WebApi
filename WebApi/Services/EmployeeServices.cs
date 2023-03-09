using WebApi.Models;
using WebApi.Repository;

namespace WebApi.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepository repo;
        public EmployeeServices(IEmployeeRepository repo)
        {
            this.repo = repo;
        }

        public int AddEmployee(Employee emp)
        {
            return repo.AddEmployee(emp);
        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return repo.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        public int UpdateEmployee(Employee emp)
        {
            return repo.UpdateEmployee(emp);
        }
    }
}
