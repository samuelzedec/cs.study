namespace Executions.Menu;
using CustomExceptions;
using Enums;

public delegate void CallMethod(MainChoice value);
public delegate void CallMethodLibrary(ChoiceLibrary value);
public delegate void CallMethodBook(ChoiceBook value);

public static class HandlingCustomExceptions
{
    public static void Format(out int option)
    {
        try
        {
            if (!int.TryParse(Console.ReadLine(), out int value))
                throw new FormatException();

            option = value;
        }
        catch (FormatException)
        {
            option = 0;
        }
    }

    public static void TreatingCases(MainChoice choice, CallMethod method)
    {
        try
        {
            method.Invoke(choice);
        }
        catch (IncorrectPasswordException e)
        {
            e.Information();
        }
    }
    
    public static void TreatingCases(ChoiceLibrary choice, CallMethodLibrary method)
    {
        try
        {
            method.Invoke(choice);
        }
        catch (EmptyQueueException e)
        {
            e.Information();
        }
        catch (IncorrectPasswordException e)
        {
            e.Information();
        }
    }
    
    public static void TreatingCases(ChoiceBook choice, CallMethodBook method)
    {
        try
        {
            method.Invoke(choice);
        }
        catch (EmptyQueueException e)
        {
            e.Information();
        }
        catch (IncorrectPasswordException e)
        {
            e.Information();
        }
    }
}