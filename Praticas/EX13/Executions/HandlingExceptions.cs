namespace Executions.Menu;
using CustomExceptions;
using Enums;

public delegate void CallMethod(MainChoice value);
public static class HandlingCustomExceptions
{
    public static void Format(out int option)
    {
        try
        {
            if (!int.TryParse(Console.ReadLine(), out int value))
                throw new CustomFormatException("Formato Inválido! Informe outro valor...");

            option = value;
        }
        catch (CustomFormatException e)
        {
            e.Information();
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
}