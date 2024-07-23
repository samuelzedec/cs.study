using _18ConstrutorEstaticos;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Construtor Estático ##\n");

        Pessoa p1 = new(19, "Maria");
        Console.WriteLine($"{p1.Nome} - {p1.Idade}");
        Console.WriteLine($"Idade Minima {Pessoa.IdadeMinima}");

        Pessoa p2 = new(18, "Marcos");
        Console.WriteLine($"{p2.Nome} - {p2.Idade}");
        Console.WriteLine($"Idade Minima {Pessoa.IdadeMinima}");
    }
}