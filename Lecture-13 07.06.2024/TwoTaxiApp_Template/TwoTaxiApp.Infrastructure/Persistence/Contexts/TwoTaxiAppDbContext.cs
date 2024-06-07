using Microsoft.EntityFrameworkCore;
using TwoTaxiApp.Domain;

namespace TwoTaxiApp.Infrastructure;

public class TwoTaxiAppDbContext : DbContext
{
    public DbSet<Passenger> Passangers { get; set; }
    public DbSet<TaxiDriver> TaxiDrivers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}
