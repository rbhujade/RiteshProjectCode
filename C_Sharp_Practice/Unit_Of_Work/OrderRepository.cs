using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Of_Work
{
    public class OrderRepository : IOrderRepository
    {
        private DBContext _dbContext;
        public OrderRepository(DBContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        public void Add()
        {

        }
        public void Delete()
        {

        }
        public void Update()
        {

        }
    }
}
