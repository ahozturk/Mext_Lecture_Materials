namespace App.Console;

public class Vakifbank : IBank
{
    public string CustomerId { get; set; }
    
    public Vakifbank(string customerId)
    {
        CustomerId = customerId;
    }

    public string GetPaid(decimal amount)
    {
        return $"{amount} TL has been paid to Vakifbank with CustomerId: {CustomerId}";
    }
}
