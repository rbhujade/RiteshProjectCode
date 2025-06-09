using CQRSWithUOW.Data;
using CQRSWithUOW.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSWithUOW.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext dataContext;

        public EmployeeRepository(DataContext _dataContext) 
        {
            dataContext = _dataContext;
        }

        public async Task<Employee> AddEmplyee(Employee employee)
        {
            if (employee != null)
            {
               await dataContext.Employees.AddAsync(employee);
               return employee;
            }
            return null;
        }

        public void DeleteEmplyee(int id)
        {
            var emp = dataContext.Employees.FirstOrDefault(a => a.Id == id);
            if (emp != null)
            {
                dataContext.Employees.Remove(emp);
            }                
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await dataContext.Employees.ToListAsync();
        }
    }
}
