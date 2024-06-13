namespace App.Console;

public class ZiraatBank : IBank
{
    public string AccessKey { get; set; }
    public decimal MaxAmount { get; set; }
    public string Password { get; set; }

    public ZiraatBank(string accessKey, decimal maxAmount, string password)
    {
        AccessKey = accessKey;
        MaxAmount = maxAmount;
        Password = password;
    }

    public string GetPaid(decimal amount)
    {
        return $"{amount} TL has been paid to Ziraat Bank with AccessKey: {AccessKey} and Password: {Password}";
    }
}
