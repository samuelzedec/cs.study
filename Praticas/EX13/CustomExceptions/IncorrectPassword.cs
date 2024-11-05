using Message.Global;
namespace CustomExceptions;

public class IncorrectPasswordException : Exception
{
    private string _text;
    public override string Message => _text;
    public IncorrectPasswordException(string value) { _text = value; }

    public void Information()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Message);
        Console.ResetColor();
        GlobalMessages.Continue();
    }
}