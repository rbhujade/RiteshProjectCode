using CQRSWithUOW.Data;
using CQRSWithUOW.Repository;

namespace CQRSWithUOW.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dataContext;      


        public UnitOfWork(DataContext dataContext)
        {
            this.dataContext = dataContext;                
        }

        public IEmployeeRepository EmployeeRepository => new EmployeeRepository(dataContext);

        public async Task<bool> SaveAsync()
        {
            return await dataContext.SaveChangesAsync() > 0;
        }
    }
}
