namespace App.Console;

public class ZiraatBankFactory : IBankFactory
{
    public IBank CreateBank()
    {
        var bank = new ZiraatBank("pa-jaa76gdina512", 50000, "ziraat123");

        return bank;
    }
}
