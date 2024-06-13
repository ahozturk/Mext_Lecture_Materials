namespace App.Console;

public class AkbankFactory : IBankFactory
{
    public IBank CreateBank()
    {
        var bank = new Akbank("pa-jaa76gdina512", 10000, new List<string> { "config1", "config2" });

        return bank;
    }
}
