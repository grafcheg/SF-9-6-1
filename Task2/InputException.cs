namespace Task2;

public class InputException : Exception
{
    private string _messageDetails = string.Empty;
    
    public InputException(string message)
    {
        _messageDetails = message;
    }
    
    public override string Message => $"Ошибка ввода: {_messageDetails}";
}