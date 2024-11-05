using Message.Global;

namespace CustomExceptions;

public class EmptyQueueException : Exception
{
    private string _text;
    public override string Message => _text;
    public EmptyQueueException(string value) { _text = value; }

    public void Information()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Message);
        Console.ResetColor();
        GlobalMessages.Continue();
    }
}