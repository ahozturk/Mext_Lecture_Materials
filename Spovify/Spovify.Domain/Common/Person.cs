namespace Spovify.Domain;

public class Person<TKey> : EntityBase<TKey>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTimeOffset Birthdate { get; set; }
}
