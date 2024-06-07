// See https://aka.ms/new-console-template for more information
using TwoTaxiApp.Domain;
using TwoTaxiApp.Infrastructure;

Console.WriteLine("Hello, World!");

TwoTaxiAppDbContext dbContext = new();

TaxiDriver taxiDriver = new()
{
    Name = "John",
    Surname = "Doe",
    PhoneNumber = "1234567890",
    Plate = "ABC123",
};

Passenger passenger = new()
{
    Name = "Jane",
    Surname = "Doe",
    PhoneNumber = "0987654321",
    CarPreference = CarPreference.Sedan,
};

dbContext.TaxiDrivers.Add(taxiDriver);

dbContext.Passangers.Add(passenger);

// dbContext.SaveChanges();

var passenger1 = dbContext.Passangers.FirstOrDefault();

System.Console.WriteLine();