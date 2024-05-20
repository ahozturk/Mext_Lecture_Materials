

using Microsoft.EntityFrameworkCore;
using Productify.Domain;

namespace Productify.Persistence;

public class ProductifyDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ProductifyDbContext(DbContextOptions<ProductifyDbContext> options) : base(options)
    {

    }

    public override int SaveChanges()
    {
        var entries = ChangeTracker.Entries();

        foreach(var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                ((EntityBase)entry.Entity).CreatedAt = DateTime.UtcNow;
                ((EntityBase)entry.Entity).IsDeleted = false;
            }
        }

        return base.SaveChanges();
    }
}
