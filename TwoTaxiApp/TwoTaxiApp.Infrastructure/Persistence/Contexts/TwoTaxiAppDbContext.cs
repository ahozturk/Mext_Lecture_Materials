using Microsoft.EntityFrameworkCore;
using TwoTaxiApp.Domain;

namespace TwoTaxiApp.Infrastructure;

public class TwoTaxiAppDbContext : DbContext
{
    public DbSet<Passenger> Passangers { get; set; }
    public DbSet<TaxiDriver> TaxiDrivers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=TwoTaxiAppDb;User Id=postgres;Password=mysecretpassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasDiscriminator<string>("person_type")
            .HasValue<Passenger>("passenger")
            .HasValue<TaxiDriver>("taxi_driver");
    }
}
