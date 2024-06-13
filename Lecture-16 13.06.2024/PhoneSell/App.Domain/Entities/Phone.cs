using App.Domain.ValueObjects;

namespace App.Domain.Entities;

public class Phone
{
    public Guid Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public Camera Camera { get; set; }

    public Phone(string brand, string model, Camera camera)
    {
        Brand = brand;
        Model = model;
        Camera = camera;
    }
}
