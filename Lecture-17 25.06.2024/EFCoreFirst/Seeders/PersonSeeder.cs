using Microsoft.EntityFrameworkCore;

namespace EFCoreFirst;

public static class PersonSeeder
{
    public static void PersonSeed(this ModelBuilder modelBuilder)
    {
        var people = new List<Person>()
        {
            new Person()
            {
                Id = Guid.NewGuid(),
                Name = "Hakan",
            },
            new Person()
            {
                Id = Guid.NewGuid(),
                Name = "Light",
            },
        };

        modelBuilder
            .Entity<Person>()
            .HasData(people);
    }
}
