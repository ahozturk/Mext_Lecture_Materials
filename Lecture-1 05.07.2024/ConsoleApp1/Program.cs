//E-Commerce Inventory Management System

using ConsoleApp1.Enums;
using ConsoleApp1.Models;
using ConsoleApp1.Models.Common;

ElectronicProduct product1 = new ElectronicProduct
{
    Id = Guid.NewGuid(),
    Name = "Smart TV",
    Price = 1200.00m,
    DefaultWarrantyDurationInDays = TimeSpan.FromDays(1 * 365) 
};

ElectronicProduct product2 = new ElectronicProduct
{
    Id = Guid.NewGuid(),
    Name = "Blender",
    Price = 150.00m,
    DefaultWarrantyDurationInDays = TimeSpan.FromDays(2 * 365) 
};

ClothingProduct product3 = new ClothingProduct
{
    Id = Guid.NewGuid(), // Generating a new unique Id
    Name = "T-Shirt",
    Price = 19.99m,
    Size = ClothingSize.M,
    Color = Color.Blue
};

Person person = new()
{
    Name = "İpek"
};

List<IDescription> descriptives = new();
descriptives.Add(product1);
descriptives.Add(product2);
descriptives.Add(product3);
descriptives.Add(person);

foreach (var descriptive in descriptives)
{
    Console.WriteLine(descriptive.GiveDescription());
}
