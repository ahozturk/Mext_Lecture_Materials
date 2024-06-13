namespace App.Console;

public class AkbankFactory : IBankFactory
{
    public IBank CreateBank()
    {
        var bank = new Akbank("pa-jaa76gdina512");

        return bank;
    }
}
