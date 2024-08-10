namespace EX4.Entities;

public partial class DevMenu
{
    private int id;
    public int ID
    {
        get { return id; }
    }

    private string? nome;
    public string? Nome
    {
        get { return nome; }
    }

    private string? cargo;
    public string? Cargo
    {
        get { return cargo; }
    }

    private string? email;
    public string? Email
    {
        get { return email; }
    }

    private string? telefone;
    public string? Telefone
    {
        get { return telefone; }
    }

    public DevMenu(string? nome, string? cargo, string? email, string? telefone)
    {
        id = Semente();
        this.nome = nome;
        this.cargo = cargo;
        this.email = email;
        this.telefone = telefone;
    }

    private int Semente()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var id = new Random(semente).Next(1000, 2000);
        return id;
    }

    public static void MenuPrincipal()
    {
        byte opcao;
        do
        {
            opcao = Menu();
            Menu(opcao);

        } while (opcao != 5);
    }

    private static byte Menu()
    {
        Console.WriteLine("<< Olá, Seja bem-vindo >>");
        Console.WriteLine("Informe o número da opção desejada:\n");
        Console.WriteLine("[1] - Ver todos os desenvolvedores");
        Console.WriteLine("[2] - Cadastrar desenvolvedor");
        Console.WriteLine("[3] - Remover desenvolvedor");
        Console.WriteLine("[4] - Ver dados de um desenvolvedor");
        Console.WriteLine("[5] - Voltar ao menu principal\n");

        try
        {
            Console.Write("> ");
            byte escolha = Convert.ToByte(Console.ReadLine());
            return escolha;
        } catch(Exception ex)
        {
            Console.WriteLine($"-- {ex.Message} --");
            Console.WriteLine($"-- {ex.StackTrace?.ToString()} --");
            Console.ReadKey();
            return 0;
        }
    }

    private static void Menu(byte escolha)
    {
        switch(escolha)
        {
            case 1:
                Console.Clear();
                Database.ListaDeDevs();
                break;
            case 2:
                Console.Clear();
                Database.AddDev();
                break;
            case 3:
                Console.Clear();
                Database.RemoverDev();
                break;
            case 4:
                Console.Clear();
                Database.VerDev();
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("-- Voltando ao menu incial --\n");
                break;
            default:
                Console.Clear();
                Console.WriteLine("-- Opção incorreta, Tente Novamente! --\n");
                break;
        }
    }
}

