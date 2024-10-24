namespace CustomExceptions;
using Message.Global;

public class CustomFormatException : Exception
{
    private string _text;
    public override string Message => _text;
    public CustomFormatException(string value) { _text = value; }

    public void Information()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Message);
        Console.ResetColor();
        GlobalMessages.Continue();
    }
}