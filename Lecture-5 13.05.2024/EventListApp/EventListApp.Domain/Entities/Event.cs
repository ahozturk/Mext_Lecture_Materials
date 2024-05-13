namespace EventListApp.Domain;

public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTimeOffset Date { get; set; }
    public Person Owner { get; set; }
}
