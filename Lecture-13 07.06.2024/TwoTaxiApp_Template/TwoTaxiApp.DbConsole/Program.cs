using TwoTaxiApp.Domain;
using TwoTaxiApp.Infrastructure;
TwoTaxiAppDbContext context = new();

#region Saving


// TaxiDriver taxiDriver = new()
// {
//     Id = Guid.NewGuid(),
//     Name = "John",
//     Surname = "Doe",
//     PhoneNumber = "123456789",
//     DriverLicenceNumber = "1u979239",
//     Plate = "AA1234AA",
// };

// context.TaxiDrivers.Add(taxiDriver);

// Passenger passenger = new()
// {
//     Id = Guid.NewGuid(),
//     Name = "Jane",
//     Surname = "Doe",
//     PhoneNumber = "987654321",
//     CarPreference = CarPreference.Any,
// };

// context.Passangers.Add(passenger);

// context.SaveChanges();

// Console.WriteLine("Data has been saved.");

#endregion

#region Reading

var taxiDrivers = context.Passangers.ToList();

foreach (var taxiDriver in taxiDrivers)
{
    Console.WriteLine($"Taxi driver: {taxiDriver.Name} {taxiDriver.Surname}");
}

#endregion