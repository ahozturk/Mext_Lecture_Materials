namespace App.Console;

public class Akbank : IBank
{
    public string AccessKey { get; set; }

    public Akbank(string accessKey)
    {
        AccessKey = accessKey;
    }

    public string GetPaid(decimal amount)
    {
        return $"{amount} TL has been paid to Akbank with AccessKey: {AccessKey}";
    }
}
