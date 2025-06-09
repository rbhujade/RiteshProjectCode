using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Of_Work
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions  dbContext) { }

        //DataSet<Employee> _employees { get; set; };
        //DataSet<Order> _orders { get; set; };
    }
}
