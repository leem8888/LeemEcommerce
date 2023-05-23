using Ecommerce.Domain.Model;
using LeemEcommerce.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace LeemEcommerce.Domain;

public class MainDbContext : DbContext
{
    public MainDbContext() :base() 
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // quan hệ n-n ; 1 product thể thuộc nhiều category ; 1 catepory có nhiều product
        modelBuilder.Entity<Product>().HasMany(p => p.Categories).WithMany(c=>c.Product);
        // quan hệ 1-n ;  1 product thuộc về 1 nhà cung cấp ; 1 nhà cung cấp có thể cung cấp nhiều product
        modelBuilder.Entity<Product>().HasOne(p => p.Supplier).WithMany(s => s.Products);
        // quan hệ n-1 ;  1 product có nhiều đánh giá; mỗi đánh giá thuộc về 1 sản phẩm
        modelBuilder.Entity<Product>().HasMany(p => p.Ratings).WithOne(r => r.Product);
        // quan hệ n-1 ;  1 product có nhiều comment; mỗi comment thuộc về 1 sản phẩm
        modelBuilder.Entity<Product>().HasMany(p => p.Comments).WithOne(r => r.Product);
        // quan hệ n-1 ;  1 comment có nhiều child comment; mỗi child comment thuộc về 1 comment
        modelBuilder.Entity<Comment>().HasMany(p => p.ChildComments).WithOne(r => r.Comment);

        modelBuilder.HasPostgresExtension("pgcrypto")
             .HasPostgresExtension("uuid-ossp");

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainDbContext).Assembly);

    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Rating> Rating { get; set; }
    public DbSet<User> Users { get;set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<ChildComment> ChildComments { get; set; }
}
