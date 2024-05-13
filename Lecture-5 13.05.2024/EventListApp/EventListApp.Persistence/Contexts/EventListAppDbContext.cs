using EventListApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace EventListApp.Persistence;

public class EventListAppDbContext : DbContext
{
    public DbSet<Event> Events { get; set; }
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("EventListApp");
    }
}
