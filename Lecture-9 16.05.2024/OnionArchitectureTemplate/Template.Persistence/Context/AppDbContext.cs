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
}
