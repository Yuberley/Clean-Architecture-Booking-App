namespace Bookify.Domain.Abstractions;

public record Error(string Code, string Message)
{
    public static Error none = new(string.Empty, string.Empty);
    public static Error NullValue = new("Error.NullValue", "Null value was provided");
}