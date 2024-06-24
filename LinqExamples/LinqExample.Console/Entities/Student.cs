namespace LinqExample.Console;

public class Student : Person
{
    public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
}
