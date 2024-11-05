namespace Message.Global;

public class GlobalMessages
{
    public static void Start()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(
            "\u001b[1mOlá. Seja bem-vindo!" +
            "\u001b[3m\nEsse pequeno sistema de uma biblioeteca fiz com intuito de praticar a manipulação de um arquivo JSON, simulando um banco de dados." +
            "\nAlém disso, pretendo praticar a programção assíncrona em C#." +
            "\nAcredito está evoluindo bastante na linguagem, então nesse sistema quero desmontrar o que aprendi de novidade na linguagem C#."
        );
        Console.ResetColor();
        Continue();
    }

    public static void Continue()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("\n\nPressione \u001b[1mEnter para continuar...");
        Console.ResetColor();
        Console.ReadKey();
    }

    public static void Invalid()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido! Informe um valor que está dentro do menu...");
        Console.ResetColor();
        Continue();
    }

    public static void GoToBack()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Voltando ao menu anterior...");
        Console.ResetColor();
        Continue();
    }
    

}