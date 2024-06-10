namespace App.Domain;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Book> Books { get; set; } = new();
    public decimal Balance { get; set; }

    public static Student operator +(Student student, Book book)
    {
        student.Books.Add(book);
        return student;
    }

    public static Student operator +(Student student, decimal amount)
    {
        student.Balance += amount;
        return student;
    }

    public static Student operator +(Student student, (string firstName, string lastName) names)
    {
        student.FirstName = names.firstName;
        student.LastName = names.lastName;
        return student;
    }
}
