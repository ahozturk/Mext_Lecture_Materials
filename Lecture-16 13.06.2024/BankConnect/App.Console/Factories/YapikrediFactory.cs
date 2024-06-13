namespace App.Console;

public class YapikrediFactory : IBankFactory
{
    public IBank CreateBank()
    {
        var id = Guid.Parse("7609b9ac-da6e-43a6-b681-436c3a270091");

        var bank = new Yapikredi("hakan@gmail.com", id);

        bank.ValidateEmail();

        return bank;
    }
}
