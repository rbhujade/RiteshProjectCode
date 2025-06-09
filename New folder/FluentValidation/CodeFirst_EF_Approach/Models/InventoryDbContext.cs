using Microsoft.EntityFrameworkCore;

namespace CodeFirst_EF_Approach.Models
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) 
        {
        
        }

        DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Order>().HasKey(x => x.Id);
            
        }
    }
}
