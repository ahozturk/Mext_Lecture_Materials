using Microsoft.EntityFrameworkCore;
using Spovify.Domain;

namespace Spovify.Persistence;

public class SpovifyDbContext : DbContext
{
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Producer> Producers { get; set; }
    public DbSet<Song> Songs { get; set; }

    //cd Spovify.Persistence
    //dotnet ef migrations add mig_1_initialize
    //dotnet ef database update
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=SpovifyDb;Username=postgres;Password=mysecretpassword");
    }

    public override int SaveChanges()
    {
        var entries = ChangeTracker
            .Entries();

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
                ((EntityBase<Guid>)entry.Entity).CreatedAt = DateTime.UtcNow;
            else if (entry.State == EntityState.Modified)
                ((EntityBase<Guid>)entry.Entity).UpdatedAt = DateTime.UtcNow;
        }

        return base.SaveChanges();
    }
}
