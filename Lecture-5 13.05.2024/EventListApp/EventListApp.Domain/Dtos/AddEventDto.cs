namespace EventListApp.Domain;

public class AddEventDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTimeOffset EventDate { get; set; }
    public Guid PersonId { get; set; }
}
