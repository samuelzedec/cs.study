namespace Message.MainMenu;
using Message.Global;

/*Mensagens feita para a classe MainMenu*/
public static class StandardMessages
{
    public static void ToStart()
    {
        Console.Clear();
        Console.WriteLine("Olá! Escolha uma das opções: " +
                          "\n[1] - Acessar como biblioteca" +
                          "\n[2] - Acessar como cliente" +
                          "\n[3] - Sair");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("> ");
        Console.ResetColor();
    }

    public static void Close()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Obrigado por testar, até a próxima...");
        Console.ResetColor();
        GlobalMessages.Continue();
    }
}