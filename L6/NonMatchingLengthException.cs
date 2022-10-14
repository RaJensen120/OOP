namespace L6;


public class NonMatchingLengthException : Exception
{
    public NonMatchingLengthException() : this("The length of the two arrays is not the same.")
    {
    }

    public NonMatchingLengthException(string message)
        : base(message)
    {
    }
    
    public NonMatchingLengthException(string message, Exception inner)
        : base(message, inner)
    {
    }

}