using Microsoft.EntityFrameworkCore;
using webshopApi.Models;

namespace webshopApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
        
    }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasMany(p => p.Categories)
            .WithMany(c => c.Products)
            .UsingEntity<ProductCategory>(
                j => j
                    .HasOne(pc => pc.Category)
                    .WithMany(c => c.ProductCategories)
                    .HasForeignKey(pt => pt.CategoryId),
                j => j
                    .HasOne(pc => pc.Product)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(pc => pc.ProductId),
                j =>
                {
                    j.HasKey(pc => new { pc.ProductId, pc.CategoryId });
                });
    }

}