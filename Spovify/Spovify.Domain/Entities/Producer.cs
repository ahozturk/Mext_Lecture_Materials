namespace Spovify.Domain;

public class Producer : Person<Guid>
{
    public Genre Genre { get; set; }
}
