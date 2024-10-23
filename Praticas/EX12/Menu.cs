using System.Text.Json;
using UserInfo;
namespace MainMenu;

public static partial class Menu
{
    private static string path = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\Praticas\EX12\Users.json";
    public static void Run()
    {
        char choice;
        do
        {
            Console.Clear();
            Console.WriteLine("\u001b[32mBem-Vindo\u001b[0m");
            Console.WriteLine("[1] - Fazer login");
            Console.WriteLine("[2] - Fazer cadastro");
            Console.WriteLine("[3] - Sair");
            Console.Write("\u001b[36m> \u001b[0m");

            choice = Console.ReadKey().KeyChar;
            Options(choice);
        } while (choice != '3');
    }

    private static void Options(char value)
    {
        switch (value)
        {
            case '1':
                Login();
                break;
            case '2':
                Create();
                break;
            case '3':
                Console.Clear();
                Console.WriteLine("Programa encerrado");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Escolha uma opção válida");
                break;
        }
    }

    private static void Login()
    {
        Console.Clear();

        string jsonString = File.ReadAllText(path);
        List<User>? users = JsonSerializer.Deserialize<List<User>>(jsonString);

        if (users is null || users.Count == 0)
        {
            Console.WriteLine("Não há usuários cadastrados.");
            Console.ReadKey();
            return;
        }

        Console.Write("Informe o seu ID: ");
        if (!int.TryParse(Console.ReadLine(), out int userId))
        {
            Console.Clear();
            Console.WriteLine("Formato de ID inválido.");
            Console.ReadKey();
            return;
        }

        Search(userId, users);
    }

    private static void Search(int id, List<User> users)
    {
        Console.Clear();

        var user = users.FirstOrDefault(x => x.Id == id);
        if (user is null)
        {
            Console.WriteLine("Usuário não encontrado.");
            Console.ReadKey();
            return;
        }

        Console.Write($"Olá {user.Name}, informe sua senha: ");
        string? password = Console.ReadLine();

        if (user.Password == password)
        {
            Console.Clear();
            Console.WriteLine("\u001b[32mLogin feito com sucesso!!!\u001b[0m");
            Console.WriteLine($"ID: {user.Id}");
            Console.WriteLine($"Nome: {user.Name}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"Senha: {user.Password}");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Senha incorreta!");
        }

        Console.ReadKey();
    }

}