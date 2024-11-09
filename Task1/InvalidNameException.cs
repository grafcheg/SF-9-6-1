namespace Task1;

public class InvalidNameException : Exception
{
    private string _messageDetails = string.Empty;
    
    public InvalidNameException(string message)
    {
        _messageDetails = message;
    }
    
    public override string Message => $"Недопустимое имя: {_messageDetails}";
}