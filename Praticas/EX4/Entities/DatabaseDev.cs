namespace EX4.Entities;

public partial class Database
{
    private static List<DevMenu> listaDev = new()
    {
        new DevMenu("José Gabriel", "SÊNIOR", "megagbl2323@gmail.com", "92 99491-6643"),
        new DevMenu("Lucas Lima", "PLENO", "lucasdelimact@gmail.com", "92 999195-7450"),
        new DevMenu("Samuel Zedec", "JUNIOR", "samuelzedec@gmail.com", "92 98564-0774")
    };

    public static void AddDev()
    {
        Console.Write("Informe o nome do desenvolvedor: ");
        string? nome = Console.ReadLine();

        Console.Write("Informe o cargo do desenvolvedor (Sênior/Pleno/Junior): ");
        string? cargo = Console.ReadLine()?.ToUpper();

        Console.Write("Informe o email do desenvolvedor: ");
        string? email = Console.ReadLine();

        Console.Write("Informe o telefone do desenvolvedor: ");
        string? telefone = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Cadastro feito com sucesso...\n");

        listaDev.Add(new DevMenu(nome, cargo, email, telefone));
    }

    public static void VerDev()
    {
        int idDev;
        try
        {
            Console.Write("Informe o id do desenvolvedor que você deseja olhar os dados: ");
            idDev = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Erro...\n");
            idDev = 0;
        }

        if (listaDev.Any(desenvolvedor => desenvolvedor.ID == idDev))
        {
            var dev = listaDev.Find(dev => dev.ID == idDev);
            Console.WriteLine($"\nNome: {dev.Nome}");
            Console.WriteLine($"Email: {dev.Email}");
            Console.WriteLine($"Telefone: {dev.Telefone}");
            Console.WriteLine($"Cargo: {dev.Cargo}\n");

            Console.ReadKey();
            Console.Clear();

        } else
        {
            Console.WriteLine("Desenvolvedor não encontrado na database...\n");
        }
    }

    public static void ListaDeDevs()
    {
        var pleno = listaDev.FindAll(x => x.Cargo == "PLENO");
        var senior = listaDev.FindAll(x => x.Cargo == "SÊNIOR");
        var junior = listaDev.FindAll(x => x.Cargo == "JUNIOR");

        Console.WriteLine("\n## Sênior ##");
        foreach(var dev in senior)
        {
            Console.WriteLine($"ID: {dev.ID} | Nome: {dev.Nome}");
        }

        Console.WriteLine("\n## Pleno ##");
        foreach (var dev in pleno)
        {
            Console.WriteLine($"ID: {dev.ID} | Nome: {dev.Nome}");
        }

        Console.WriteLine("\n## Junior ##");
        foreach (var dev in junior)
        {
            Console.WriteLine($"ID: {dev.ID} | Nome: {dev.Nome}");
        }

        Console.ReadKey();
        Console.Clear();
    }

    public static void RemoverDev()
    {
        int devId;

        try
        {
            Console.Write("Informe o id do desenvolvedor que deseja remover: ");
            devId = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Valor inválido...\n");
            devId = 0;
        }

        var index = listaDev.FindIndex(x => x.ID == devId);

        if(index >= 0)
        {
            Console.WriteLine("\nDeseja remover o desenvolvedor:");
            Console.WriteLine($"Nome: {listaDev[index].Nome}");
            Console.WriteLine($"Cargo: {listaDev[index].Cargo}");
            Console.WriteLine($"Email: {listaDev[index].Email}");
            Console.WriteLine($"Telefone: {listaDev[index].Telefone}");

            Console.WriteLine("\nA. Sim");
            Console.WriteLine("B. Não");
            Console.Write("> ");

            char letra = Console.ReadKey().KeyChar;
            char escolha = char.ToUpper(letra);

            if(escolha == 'A')
            {
                listaDev.RemoveAt(index);
                Console.Clear();
                Console.WriteLine("Desenvolvedor removido com sucesso\n");
            } else
            {
                Console.Clear();
                Console.WriteLine("Operação cancelada...\n");
            }

        } else
        {
            Console.Clear();
            Console.WriteLine("Desenvolvedor não encontrado na Database...\n");
        }
    }

}

