namespace L5;

public class NegativeIntegerException : Exception
{
    public NegativeIntegerException()
    {
    }

    public NegativeIntegerException(string message)
        : base(message)
    {
    }
    
    public NegativeIntegerException(string message, Exception inner)
        : base(message, inner)
    {
    }

}