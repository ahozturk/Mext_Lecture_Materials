namespace GPTExample.Domain;

public class EntityBase<TKey>
{
    public TKey Id { get; set; }

    public DateTimeOffset CreatedDate { get; set; }
    public string CreatedBy { get; set; }

    public DateTimeOffset ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}
