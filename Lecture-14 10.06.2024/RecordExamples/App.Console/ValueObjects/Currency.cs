namespace App.Console;

public record Currency
{
    public static Currency USD => new Currency("USD");
    public static Currency TRY => new Currency("TRY");

    private string Code { get; }

    private Currency(string code)
    {
        Code = code;

    }

    override public string ToString()
    {
        return Code;
    }
}
