using Microsoft.EntityFrameworkCore;
using Template.Domain;

namespace Template.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=TemplateAppDb;User Id=postgres;Password=mysecretpassword;");
    }

    public override int SaveChanges()
    {
        var entries = ChangeTracker.Entries();

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
                ((EntityBase)entry.Entity).CreatedAt = DateTime.UtcNow;

            else if (entry.State == EntityState.Modified)
                ((EntityBase)entry.Entity).ModifiedAt = DateTime.UtcNow;
            
        }

        return base.SaveChanges();
    }
}
