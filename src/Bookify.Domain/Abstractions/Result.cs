using System.Diagnostics.CodeAnalysis;

namespace Bookify.Domain.Abstractions;

public class Result
{
    protected internal Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.none)
        {
            throw new InvalidOperationException();
        }
        
        if (!isSuccess && error == Error.none)
        {
            throw new InvalidOperationException();
        }
        
        IsSuccess = isSuccess;
        Error = error;
    }
    
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; }
    
    public static Result Success() => new(true, Error.none);
    public static Result Failure(Error error) => new(false, error);
    public static Result<T> Success<T>(T value) => new(value, true, Error.none);
    public static Result<T> Failure<T>(Error error) => new(default, false, error);
    
    public static Result<T> Create<T>(T? value) => value is not null ? Success(value) : Failure<T>(Error.NullValue);
}

public class Result<T> : Result
{
    private readonly T? _value;
    protected internal Result(T? value, bool isSuccess, Error error) : base(isSuccess, error)
    {
        _value = value;
    }
    
    [NotNull]
    public T Value => IsSuccess
        ? _value!
        : throw new InvalidOperationException("There is no value for failure result. Check IsSuccess before accessing the value.");
    
    public static implicit operator Result<T>(T value) => Create(value);
}