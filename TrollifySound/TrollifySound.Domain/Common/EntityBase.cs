namespace TrollifySound.Domain.Common;

public class EntityBase
{
    public Guid Id { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdateAt { get; set; }
    public bool IsDeleted { get; set; }
}
