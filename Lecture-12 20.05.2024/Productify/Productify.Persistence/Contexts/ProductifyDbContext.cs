

using Microsoft.EntityFrameworkCore;
using Productify.Domain;

namespace Productify.Persistence;

public class ProductifyDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ProductifyDbContext(DbContextOptions<ProductifyDbContext> options) : base(options)
    {
        
    }

    public override int SaveChanges() //Interception Mechanism
    {
        var entries = ChangeTracker.Entries();

        foreach(var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                ((EntityBase)entry.Entity).CreatedAt = DateTime.UtcNow.AddHours(-1);
                ((EntityBase)entry.Entity).IsDeleted = false;
            }
            else if (entry.State == EntityState.Modified)
            {
                ((EntityBase)entry.Entity).UpdatedAt = DateTime.UtcNow;
            }
        }

        return base.SaveChanges();
    }
}
