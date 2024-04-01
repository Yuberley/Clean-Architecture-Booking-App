namespace Bookify.Domain.Apartments;

public record Currency
{
    public string Code { get; init; }
    
    public Currency(string code) => Code = code;
    
    internal static readonly Currency None = new("");
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EUR");

    public static readonly IReadOnlyCollection<Currency> All = new List<Currency>
    {
        Usd,
        Eur
    };
    
    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(x => x.Code == code) ?? 
               throw new ArgumentException($"Currency with code {code} not found");
    }

};