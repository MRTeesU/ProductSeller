using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Models;


public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    
    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Product>(x =>
        {
            x.Property(c => c.Name).IsRequired();
            x.Property(c => c.Description).IsRequired();
            x.Property(c => c.Price).IsRequired();
            x.Property(c => c.InStock).IsRequired();
        });
    }
}
