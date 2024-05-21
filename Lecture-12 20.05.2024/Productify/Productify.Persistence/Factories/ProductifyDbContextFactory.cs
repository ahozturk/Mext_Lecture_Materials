using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace Productify.Persistence;

public class ProductifyDbContextFactory : IDesignTimeDbContextFactory<ProductifyDbContext>
{
    public ProductifyDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ProductifyDbContext>();

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath($"{Directory.GetParent(Directory.GetCurrentDirectory())}/Productify.Presentation")
            .AddJsonFile("appsettings.json")
            .Build();

        // Get connection string
        var connectionString = configuration.GetConnectionString("PostgreSQL");

        // Configure the DbContext to use PostgreSQL
        optionsBuilder.UseNpgsql(connectionString);

        return new ProductifyDbContext(optionsBuilder.Options);
    }
}
