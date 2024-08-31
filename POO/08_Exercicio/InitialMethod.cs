namespace Menu;
using DataBase;
internal partial class Home
{
    //Método usado para quando o usuário inserir um valor inválido
    private static void Default()
    {
        Console.Clear();
        Console.WriteLine("Opção Incorreta...Tente Novamente!");
        Console.Write("Pressione Enter para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
    //Método usado para encerrar o programa
    private static void Exit()
    {
        Console.Clear();
        Console.WriteLine("Programa encerrado... Obrigado por testar!");
    }

    //Métodos usados para a criação de conta
    private static void CreateAccount()
    {
        Console.Clear();
        Console.WriteLine("Olá, Você está preste a criar a sua conta!\n");
        Console.Write("Informe seu nome completo: ");
        string name = Console.ReadLine();

        ValidateName(ref name);
        CreateAccount(name);
    }

    private static void ValidateName(ref string name)
    {
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Clear();
            Console.WriteLine("Você não informou um único nome, tente novamente...");
            Console.Write("Informe novamente seu nome completo: ");
            name = Console.ReadLine();
        }
    }

    private static void CreateAccount(string name)
    {
        User user = new(name);
        char choice;

        do
        {
            Console.Clear();
            Console.WriteLine("Você deseja criar sua conta com o seguintes dados: ");
            Console.WriteLine($"Nome: {user.Name} \nID da conta: {user.ID}");
            Console.WriteLine("A. Sim | B. Não");
            Console.Write("> ");

            choice = Console.ReadKey().KeyChar;
            choice = char.ToUpper(choice);

            UserCase(choice, user);

        } while (choice != 'A' && choice != 'B');
    }

    private static void UserCase(char choice, User user)
    {
        switch (choice)
        {
            case 'A':
                Console.Clear();
                Console.Write("Conta criada com sucesso... Faça Login na sua conta! \nPressione Enter para continuar...");
                Console.ReadKey();
                users.Add(user);
                break;
            case 'B':
                Console.Clear();
                Console.Write("Cancelmento ao criar conta... \nPressione Enter para continuar...");
                Console.ReadKey();
                break;
            default:
                Console.Clear();
                Console.Write("Informe um valor válido... \nPressione Enter para continuar...");
                Console.ReadKey();
                break;
        }
    }
    //Aqui finalizamos tudo sobre a criaçãp de conta

    //Vamos começar a parte de login do usúario
    private static void Login()
    {
        Console.Clear();
        int id;
        try
        {
            Console.Write("Informe o ID da sua conta para fazer login: ");
            id = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex?.StackTrace?.ToString());
            Console.Write("\n\nPressione Enter para continuar...");
            id = 0;
            Console.ReadKey();
        }

        if(users.Any(user => user.ID == id))
        {
            var user = users.Find(user => user.ID == id);
            user?.Menu();
        } else
        {
            Console.Clear();
            Console.WriteLine("ID não encontrado no datababe do banco. \nPressione Enter para continuar...");
            Console.ReadKey();
        }
    }
}
