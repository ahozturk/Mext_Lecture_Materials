#region Banks

class Vakifbank : IBank
{
    public string CustomerId { get; set; }
    
    public Vakifbank(string customerId)
    {
        CustomerId = customerId;
    }

    public void GetPaid(decimal amount)
    {
        Console.WriteLine($"{amount} TL has been paid to Vakifbank with CustomerId: {CustomerId}");
    }
}

class Yapikredi : IBank
{
    public string Email { get; set; }
    public Guid CustomerKey { get; set; }

    public Yapikredi(string email, Guid customerKey)
    {
        Email = email;
        CustomerKey = customerKey;
    }

    public void GetPaid(decimal amount)
    {
        Console.WriteLine($"{amount} TL has been paid to Yapikredi with Email: {Email} and CustomerKey: {CustomerKey}");
    }
}

class Akbank : IBank
{
    public string AccessKey { get; set; }

    public Akbank(string accessKey)
    {
        AccessKey = accessKey;
    }

    public void GetPaid(decimal amount)
    {
        Console.WriteLine($"{amount} TL has been paid to Akbank with AccessKey: {AccessKey}");
    }
}

#endregion

#region Abstractions

interface IBank
{
    void GetPaid(decimal amount);
}

#endregion

#region Abstract Factory

interface IBankFactory
{
    IBank CreateBank();
}

#endregion