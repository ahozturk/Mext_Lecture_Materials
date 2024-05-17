namespace Spovify.Domain;

public class Artist : Person<Guid>
{
    public string Nick { get; set; }
}
