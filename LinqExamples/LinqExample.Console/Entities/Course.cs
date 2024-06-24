namespace LinqExample.Console;

public class Course : EntityBase
{
    public string Title { get; set; }
    public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    public List<Teacher> Teachers { get; set; }
    public Asistant Asistant { get; set; }
}
