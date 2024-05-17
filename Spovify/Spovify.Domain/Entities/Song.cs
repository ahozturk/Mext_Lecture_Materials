namespace Spovify.Domain;

public class Song : EntityBase<Guid>
{
    public string Name { get; set; }
    public string Artist { get; set; }
}
