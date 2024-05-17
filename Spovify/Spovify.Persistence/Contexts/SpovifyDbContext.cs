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
}
