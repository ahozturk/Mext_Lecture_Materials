namespace App.Console;

public class VakifbankFactory : IBankFactory
{
    public IBank CreateBank()
    {
        var bank = new Vakifbank("1234567890");

        return bank;
    }
}
