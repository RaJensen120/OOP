namespace L5;

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException() : this("Insufficient funds.")
    {
    }

    public InsufficientFundsException(string message)
    : base(message)
    {
    }
    
    public InsufficientFundsException(string message, Exception inner)
        : base(message, inner)
    {
    }

}