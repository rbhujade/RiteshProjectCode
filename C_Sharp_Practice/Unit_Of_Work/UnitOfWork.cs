using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Of_Work
{
    public class UnitOfWork
    {
        private IEmployeeRepository _employeeRepository;
        private IOrderRepository _orderRepository;
        private DBContext _dbContext;

        public UnitOfWork(DBContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        public IEmployeeRepository EmployeeRep()
        {
            if(_employeeRepository == null)
            {
                _employeeRepository = new EmployeeRepository(_dbContext);
            }
            
            return _employeeRepository;
        }

        public IOrderRepository OrderRep() 
        { 
            if(_orderRepository == null)
            {
                _orderRepository = new OrderRepository(_dbContext);
            }

            return _orderRepository;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

    }
}
