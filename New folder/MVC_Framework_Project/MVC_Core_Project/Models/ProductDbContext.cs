using Microsoft.EntityFrameworkCore;

namespace MVC_Core_Project.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
