using GPTExample.Domain;
using Microsoft.EntityFrameworkCore;

namespace GPTExample.Persistence;

public class GPTExampleDbContext : DbContext
{
    public DbSet<GPTPrompt> Prompts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=GPTExampleDb;User Id=postgres;Password=mysecretpassword;");
    }
}
