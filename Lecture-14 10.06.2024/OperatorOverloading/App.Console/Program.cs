using App.Domain;

Book book1 = new("The Catcher in the Rye", "J.D. Salinger");
Book book2 = new("To Kill a Mockingbird", "Harper Lee");

Student student = new()
{
    FirstName = "John",
    LastName = "Doe",
};

// student.Books.Add(book1);
// student.Books.Add(book2);

student = student + book1;
student += book2;

student = student + 100.00m;

student += ("Hakan", "Öztürk");