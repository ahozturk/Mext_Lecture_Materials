namespace App.Console;

public record Money
{
    public decimal Price { get; set; } //10
    public Currency Currency { get; set; } //"USD", "EUR", "TRY"

    public Money(Currency currency, decimal price)
    {
        Currency = currency;
        Price = price;
    }

    
}
