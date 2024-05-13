namespace EventListApp.Domain;

public class Event : EntityBase
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTimeOffset Date { get; set; }
    public Person Owner { get; set; }
}
