using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI.Models
{
    public class ProductDbContext :DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> option):base(option)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
