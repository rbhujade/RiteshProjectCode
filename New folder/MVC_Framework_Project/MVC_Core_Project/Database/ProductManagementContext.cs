using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MVC_Core_Project.Models;

namespace MVC_Core_Project.Database;

public partial class ProductManagementContext : DbContext
{
    public ProductManagementContext()
    {
    }

    public ProductManagementContext(DbContextOptions<ProductManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ProductManagement;Integrated Security=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

public DbSet<MVC_Core_Project.Models.Product> Product { get; set; } = default!;
}
