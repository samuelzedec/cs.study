namespace Menu;
using DataBase;

internal partial class Home
{
    private static List<User> users = new List<User>();

    public static void Menu()
    {
        char choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Olá, seja bem-vindo!");
            Console.WriteLine("Informe a opçao desejada:");
            Console.WriteLine("A. Criar Conta");
            Console.WriteLine("B. Fazer Login");
            Console.WriteLine("C. Encerrar programa...");
            Console.Write("> ");

            choice = Console.ReadKey().KeyChar;
            choice = char.ToUpper(choice);

            Case(choice);

        } while(choice != 'C');
    }

    private static void Case(char choice) 
    {
        switch (choice) 
        {
            case 'A':
                CreateAccount();
                break;
            case 'B':
                Login();
                break;
            case 'C':
                Exit();
                break;
            default:
                Default();
                break;
        }
    }

}

