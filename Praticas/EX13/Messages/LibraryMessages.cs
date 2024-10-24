namespace Messages.Library;

public static class LibraryMessages
{
    public static void ValidateName()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Para acessar é necessário informar a senha da biblioteca!\u001b[0m");
        Console.Write("Digite a senha: ");
    }
}