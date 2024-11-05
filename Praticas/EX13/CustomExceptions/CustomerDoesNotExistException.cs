using Message.Global;
namespace CustomExceptions;

public class CustomerDoesNotExistException : Exception
{
    private string _text;
    public override string Message => _text;
    public CustomerDoesNotExistException(string value) { _text = value; }

    public void Information()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Message);
        Console.ResetColor();
        GlobalMessages.Continue();
    }
}