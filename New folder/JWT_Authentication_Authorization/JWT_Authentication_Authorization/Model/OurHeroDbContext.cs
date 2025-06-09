using Microsoft.EntityFrameworkCore;

namespace JWT_Authentication_Authorization.Model
{
    public class OurHeroDbContext : DbContext
    {
        public OurHeroDbContext(DbContextOptions<OurHeroDbContext> options) : base(options)
        {

        }

        public DbSet<OurHero> OurHeros { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OurHero>().HasKey(s=> s.ID);

            modelBuilder.Entity<OurHero>().HasData(new OurHero
            {
                ID = 1,
                FirstName = "System",
                LastName ="",
                IsActive = true
            });

            modelBuilder.Entity<User>().HasData(new User 
            {
                Id = 1,
                FirstName="System",
                LastName="System",
                Password = "System",
                Username = "System",
                isActive = true
            });

        }
    }
}
