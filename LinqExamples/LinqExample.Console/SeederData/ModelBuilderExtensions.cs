using Microsoft.EntityFrameworkCore;

namespace LinqExample.Console;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var courseId = Guid.NewGuid();
    var student1Id = Guid.NewGuid();
    var student2Id = Guid.NewGuid();

    modelBuilder.Entity<Course>().HasData(
        new Course { Id = courseId, Title = "Math" }
    );

    modelBuilder.Entity<Student>().HasData(
        new Student { Id = student1Id, FirstName = "John Doe", LastName = "Öztürk" },
        new Student { Id = student2Id, FirstName = "Jane Doe", LastName = "Öztürk" }
    );

    modelBuilder.Entity<StudentCourse>().HasData(
        new StudentCourse { StudentId = student1Id, CourseId = courseId },
        new StudentCourse { StudentId = student2Id, CourseId = courseId }
    );
    }
}
