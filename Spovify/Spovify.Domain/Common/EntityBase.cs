namespace Spovify.Domain;

public class EntityBase<TKey>
{
    public TKey Id { get; set; }
    
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }
}
