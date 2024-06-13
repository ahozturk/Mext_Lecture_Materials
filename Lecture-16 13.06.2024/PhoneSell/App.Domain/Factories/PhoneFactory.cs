using App.Domain.Entities;
using App.Domain.ValueObjects;

namespace App.Domain;

public class PhoneFactory : IFactory
{

    public object CreateInstance(string brand, string model)
    {
        var camera = new Camera(1.4m, 1, 3);
        var phone = new Phone(brand, model, camera);
        
        return phone;
    }
}
