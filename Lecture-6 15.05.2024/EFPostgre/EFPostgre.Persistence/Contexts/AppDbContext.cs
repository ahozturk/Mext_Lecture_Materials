using EFPostgre.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFPostgre.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=MyFirstPostgreDb;User Id=postgres;Password=mysecretpassword;");

        //dotnet ef migrations add mig_1_Initialization

        //dotnet ef database update
    }
}
