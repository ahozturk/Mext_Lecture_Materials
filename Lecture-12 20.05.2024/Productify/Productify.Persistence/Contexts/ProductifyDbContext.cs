

using Microsoft.EntityFrameworkCore;
using Productify.Domain;

namespace Productify.Persistence;

public class ProductifyDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ProductifyDbContext(DbContextOptions<ProductifyDbContext> options) : base(options)
    {
        
    }
}
