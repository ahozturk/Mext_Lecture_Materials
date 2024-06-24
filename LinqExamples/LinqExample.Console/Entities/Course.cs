namespace LinqExample.Console;

public class Course : EntityBase
{
    public string Title { get; set; }
    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }
    public Asistant Asistant { get; set; }
}
