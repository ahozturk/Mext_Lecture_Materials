// See https://aka.ms/new-console-template for more information

Person hakan = new();

hakan += 10;


System.Console.WriteLine(hakan.Budget);

class Person
{
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public decimal Length { get; set; }

    public static implicit operator decimal(Person person)
    {
        return person.Budget * 2;
    }

    public static bool operator ==(Person person1, Person person2)
    {
        if (person1 is null)
            return false;

        if (person2 is null)
            return false;

        return false;

    }

    public static bool operator !=(Person person1, Person person2)
    {
        return true;
    }

    public static Person operator +(Person person, int amount)
    {
        person.Budget += amount;
        return person;
    }
}