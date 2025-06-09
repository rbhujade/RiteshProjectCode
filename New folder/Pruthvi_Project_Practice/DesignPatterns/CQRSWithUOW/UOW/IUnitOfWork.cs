using CQRSWithUOW.Repository;

namespace CQRSWithUOW.UOW
{
    public interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; }
        Task<bool> SaveAsync();
    }
}
