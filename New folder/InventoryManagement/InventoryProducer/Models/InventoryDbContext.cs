using Microsoft.EntityFrameworkCore;

namespace InventoryProducer.Models
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) { }
        DbSet<InventoryUpdateRequest> InventoryUpdateRequest { get; set; }
    }
}
