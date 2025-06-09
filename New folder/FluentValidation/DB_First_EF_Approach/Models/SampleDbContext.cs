using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DB_First_EF_Approach.Models;

public partial class SampleDbContext : DbContext
{
    public SampleDbContext()
    {
    }

    public SampleDbContext(DbContextOptions<SampleDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuditPerson> AuditPersons { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<RankDemo> RankDemos { get; set; }

    public virtual DbSet<TbEmployee> TbEmployees { get; set; }

    public virtual DbSet<TbInventory> TbInventories { get; set; }

    public virtual DbSet<TbProduct> TbProducts { get; set; }

    public virtual DbSet<TbStudent> TbStudents { get; set; }

    public virtual DbSet<TbTest> TbTests { get; set; }

    public virtual DbSet<TempTb> TempTbs { get; set; }

    public virtual DbSet<TestView> TestViews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Sample_DB;Integrated Security=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuditPerson>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Audit_Persons");

            entity.Property(e => e.AuditAction)
                .HasColumnType("text")
                .HasColumnName("Audit_Action");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderName).HasMaxLength(250);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Country)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("country");
            entity.Property(e => e.PersonName)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("person_name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Product)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("product");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<RankDemo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rank_demo");

            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.FirstName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("last_name");
        });

        modelBuilder.Entity<TbEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TB_Emplo__3214EC277CBE842B");

            entity.ToTable("TB_Employee", tb => tb.HasTrigger("trg_insert_Employee"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbInventory>(entity =>
        {
            entity.HasKey(e => e.InventoryId).HasName("PK__TB_Inven__2B65F40B5EBE0EBC");

            entity.ToTable("TB_Inventory");

            entity.Property(e => e.InventoryId).HasColumnName("Inventory_ID");
            entity.Property(e => e.InventoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Inventory_Name");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.MinLevel).HasColumnName("min_level");
            entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Product).WithMany(p => p.TbInventories)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Product_ID");
        });

        modelBuilder.Entity<TbProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__TB_Produ__9834FB9A6ABB9B44");

            entity.ToTable("TB_Product");

            entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Product_Name");
        });

        modelBuilder.Entity<TbStudent>(entity =>
        {
            entity.ToTable("TB_Student");

            entity.HasIndex(e => e.Id, "student_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Contact).HasMaxLength(50);
            entity.Property(e => e.Course).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TB_Test__3214EC272E915FA6");

            entity.ToTable("TB_Test");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempTb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_tb");

            entity.Property(e => e.Country)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.PersonName)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("person_name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Product)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("product");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<TestView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Test_View");

            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
