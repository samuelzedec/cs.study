namespace EX4.Entities;

public class TaskMenu
{
    private string? task;
    public string? Task
    {
        get { return task; }
    }

    private string? descricao;
    public string? Descricao
    {
        get { return descricao; }
    }

    private DateTime entrega;
    public DateTime Entrega
    {
        get { return entrega; }
    }

    private DateTime criado;
    public DateTime Criado
    {
        get { return criado; }
    }

    public List<DevMenu> equipe { get; set; }

    private char prioridade;
    public char Prioridade
    {
        get { return prioridade; }
    }

    private int codigo;
    public int Codigo
    {
        get { return codigo; }
    }

    private int Semente()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var id = new Random(semente).Next(1000, 2000);
        return id;
    }

    public TaskMenu(string? task, string? descricao, int dias, char prioridade)
    {
        DateTime criado = DateTime.Now;

        DateTime entrega = criado;
        entrega = entrega.AddDays(dias);

        this.task = task;
        this.descricao = descricao;
        this.entrega = entrega;
        this.criado = criado;
        this.prioridade = prioridade;
        codigo = Semente();
        equipe = new List<DevMenu>();
    }

    public static void MenuPrincipal()
    {
        byte opcao;
        do
        {
            opcao = Menu();
            Menu(opcao);

        } while (opcao != 7);
    }

    private static byte Menu()
    {
        Console.WriteLine("<< Olá, Seja bem-vindo >>");
        Console.WriteLine("Informe o número da opção desejada:\n");
        Console.WriteLine("[1] - Ver todas as task");
        Console.WriteLine("[2] - Cadastrar task");
        Console.WriteLine("[3] - Ver task expecífica");
        Console.WriteLine("[4] - Concluir task");
        Console.WriteLine("[5] - Cadastrar dev em uma task");
        Console.WriteLine("[6] - Remover dev de uma task");
        Console.WriteLine("[7] - Voltar ao menu principal\n");

        try
        {
            Console.Write("> ");
            byte escolha = Convert.ToByte(Console.ReadLine());
            return escolha;
        }
        catch (Exception ex)
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
                Database.VerTodasAsTask();
                break;
            case 2:
                Console.Clear();
                Database.CadastrarTask();
                break;
            case 3:
                Console.Clear();
                Database.TaskCompleta();
                break;
            case 4:
                Console.Clear();
                Database.ConcluirTask();
                break;
            case 5:
                Console.Clear();
                Database.CadastrarDevEmUmaTask();
                break;
            case 6:
                Console.Clear();
                Database.RemoverDevDaTask();
                break;
            case 7:
                Console.Clear();
                Console.WriteLine("Voltando ao menu incial...\n");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção incorreta... Tente novamente!\n");
                break;
        }
    }


}

