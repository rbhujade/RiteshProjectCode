using CQRSWithUOW.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSWithUOW.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
