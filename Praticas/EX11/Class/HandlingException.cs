namespace Class.HandlingException;
using MyException;
using GlobalMessage;

public delegate void CallMethod(char choice);

public class Handling
{
    protected void HandlingMyExceptions(char decision, CallMethod method)
    {
        try
        {
            method.Invoke(decision);
        }
        catch (DoesNotExistRepositoryException e)
        {
            Console.Clear();
            Console.WriteLine($"{e.Message} \nMeu github: {e.HelpLink}");
            GlobalMessage.Continue();
        }
        catch (ErrorMessageInRepository e) when (e.Message.Contains("E1001"))
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            GlobalMessage.Continue();
        }
        catch (ErrorMessageInRepository e) when (e.Message.Contains("E1002"))
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            GlobalMessage.Continue();
        }
        catch (ErrorMessageInRepository e) when (e.Message.Contains("E1003"))
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            GlobalMessage.Continue();
        }
        catch (ErrorMessageInRepository e) when (e.Message.Contains("E1004"))
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            GlobalMessage.Continue();
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("\u001b[31mVocê informou um valor inválido!\u001b[0m");
            GlobalMessage.Continue();
        }
    }
}