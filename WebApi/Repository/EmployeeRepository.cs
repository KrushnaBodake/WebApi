using WebApi.Data;
using WebApi.Models;

namespace WebApi.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext db;
        public EmployeeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
    
        public int AddEmployee(Employee emp)
        {
            int result = 0;
            db.Employees.Add(emp);
            result=db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int result = 0;
           var emp= db.Employees.Find(id);
            if(emp != null)
            {
                db.Employees.Remove(emp);
                result=db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
           var emp= db.Employees.Find(id);
            return emp;
        }

        public int UpdateEmployee(Employee emp)
        {
            int result = 0;
            var employe= db.Employees.Find(emp.Empid);
            if(employe != null)
            {
                employe.Empname = emp.Empname;
                employe.Deptname = emp.Deptname;
                employe.Salary = emp.Salary;
                employe.Age = emp.Age;
                result=db.SaveChanges();
            }
            return result;
        }
    }
}
