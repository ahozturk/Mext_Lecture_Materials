namespace App.Console;

public class Akbank : IBank
{
    public string AccessKey { get; set; }
    public decimal MaxAmount { get; set; }
    public List<string> Configurations { get; set; }

    public Akbank(string accessKey, decimal maxAmount, List<string> configurations)
    {
        AccessKey = accessKey;
        MaxAmount = maxAmount;
        Configurations = configurations;
    }

    public string GetPaid(decimal amount)
    {
        return $"{amount} TL has been paid to Akbank with AccessKey: {AccessKey}";
    }
}
