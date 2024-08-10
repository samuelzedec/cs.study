namespace EX4.Entities;

public class MenuInicial
{
    public static void Incio()
    {
        char escolha = '\0';
        do
        {
            escolha = Menu();
            Menu(escolha);

        } while (escolha != 'C');
    }

    private static char Menu()
    {
        Console.WriteLine("<< Menu Inicial >>");
        Console.WriteLine("Informe a letra da opção desejada:\n");
        Console.WriteLine("A. Desenvolvedores");
        Console.WriteLine("B. Task");
        Console.WriteLine("C. Encerrar Programa");

        Console.Write("\n> ");
        char escolha = Console.ReadKey().KeyChar;

        char escolhaUpper = char.ToUpper(escolha);
        return escolhaUpper;
    }

    private static void Menu(char escolha)
    {
        switch(escolha)
        {
            case 'A':
                Console.Clear();
                DevMenu.MenuPrincipal();
                break;
            case 'B':
                Console.Clear();
                TaskMenu.MenuPrincipal();
                break;
            case 'C':
                Console.Clear();
                Console.WriteLine("## Programa encerrado...\n");
                break;
            default:
                Console.Clear();
                Console.WriteLine("## Informe um valor valído...\n");
                break;
        }
    }
}