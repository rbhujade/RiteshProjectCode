using CQRSWithUOW.Models;

namespace CQRSWithUOW.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee> AddEmplyee(Employee employee);
        void DeleteEmplyee(int id);
    }
}
