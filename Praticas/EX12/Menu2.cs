namespace MainMenu;
using UserInfo;
using System.Text.Json;



public static partial class Menu
{
    private static void Create()
    {
        Console.Clear();
        Console.Write("Informe seu nome: ");
        var name = Console.ReadLine();

        Console.Write("Informe um email: ");
        var email = Console.ReadLine();

        Console.Write("Informe uma senha: ");
        var password = Console.ReadLine();
        
        string jsonString = File.ReadAllText(path);
        List<User>? users = JsonSerializer.Deserialize<List<User>>(jsonString) ?? new();

        User user = new(name, email, password);
        users.Add(user);

        Console.Clear();
        Console.WriteLine($"Seu id {user.Id}");
        Console.ReadKey();
        
        using (FileStream stream = new(path, FileMode.Create))
        {
            JsonSerializer.Serialize(stream, users);
        }

        Console.Clear();
        Console.WriteLine("Conta criada com sucesso");
        Console.ReadKey();
    }
}