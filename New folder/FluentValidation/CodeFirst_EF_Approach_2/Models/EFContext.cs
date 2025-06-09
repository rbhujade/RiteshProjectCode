using Microsoft.EntityFrameworkCore;

namespace CodeFirst_EF_Approach_2.Models
{
    public class EFContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Sample_DB;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
