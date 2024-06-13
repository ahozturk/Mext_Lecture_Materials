namespace App.Console;

public static class BankGenerator
{
    public static IBank Generate(BankType bankType)
    {
        IBankFactory bankFactory = bankType switch
        {
            BankType.Akbank => new AkbankFactory(),
            BankType.Vakifbank => new VakifbankFactory(),
            BankType.Yapikredi => new YapikrediFactory(),
            BankType.ZiraatBank => new ZiraatBankFactory(),
        };

        var bank = bankFactory.CreateBank();

        return bank;
    }
}
