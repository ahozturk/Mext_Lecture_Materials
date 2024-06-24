using Microsoft.EntityFrameworkCore;

namespace LinqExample.Console;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
            new Student { Id = Guid.NewGuid(), FirstName = "John Doe"},
            new Student { Id = Guid.NewGuid(), FirstName = "Jane Doe"}
        );
    }
}
