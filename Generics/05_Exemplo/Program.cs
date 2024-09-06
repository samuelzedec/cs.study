internal class Program
{
    public static void Main(string[] args)
    {
        Console.Clear(); 
        Console.WriteLine("## Exemplo do uso do GetHashCode e Equals ##\n");

        Pessoa p1 = new(123456, "Erica");
        Pessoa p2 = new(123456, "Erica");
        Pessoa p3 = new(987654, "Erica"); 

        Console.WriteLine("pessoa 1 -> Cpf = 123456 Nome = Erica");
        Console.WriteLine("pessoa 1 -> Cpf = 123456 Nome = Erica");
        Console.WriteLine("pessoa 1 -> Cpf = 987654 Nome = Erica");

        Console.WriteLine("\nComparando objetos Pessoa - GetHasCode");
        Console.WriteLine($"p1 = {p1.GetHashCode()}");
        Console.WriteLine($"p2 = {p2.GetHashCode()}");
        Console.WriteLine($"p3 = {p3.GetHashCode()}");

        Console.WriteLine("\nComparando objetos Pessoa - Equals");
        Console.WriteLine($"p1.Equals(p2) -> {p1.Equals(p2)}");
        Console.WriteLine($"p1.Equals(p3) -> {p1.Equals(p3)}");

        Console.ReadKey();
    }
}

public class Pessoa
{
    public int Cpf { get; }
    public readonly string Nome;

    public Pessoa(int cpf, string nome)
    {
        this.Cpf = cpf;
        this.Nome = nome;
    }

    public override bool Equals(object? obj)
    {
        if(obj == null) return false;

        if(!(obj is Pessoa)) return false;
        //if(obj is not Pessoa) return false

        var other = obj as Pessoa;
        return Cpf.Equals(other?.Cpf);
    }

    public override int GetHashCode()
    {
        return Cpf.GetHashCode();
    }
}