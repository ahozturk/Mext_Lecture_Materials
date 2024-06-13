namespace App.Console;

public class Yapikredi : IBank
{
    public string Email { get; set; }
    public Guid CustomerKey { get; set; }

    public Yapikredi(string email, Guid customerKey)
    {
        Email = email;
        CustomerKey = customerKey;
    }

    public void ValidateEmail()
    {
        if (string.IsNullOrEmpty(Email))
        {
            throw new Exception("Email is required");
        }
    }

    public string GetPaid(decimal amount)
    {
        return $"{amount} TL has been paid to Yapikredi with Email: {Email} and CustomerKey: {CustomerKey}";
    }
}
