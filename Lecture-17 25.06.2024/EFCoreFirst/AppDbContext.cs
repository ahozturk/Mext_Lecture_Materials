using Microsoft.EntityFrameworkCore;

namespace EFCoreFirst;

public class AppDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MyFirstDb;User Id=postgres;Password=mysecretpassword;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.PersonSeed();
    }
}
