namespace App.Domain;

public interface IFactory
{
    object CreateInstance(string brand, string model);
}
