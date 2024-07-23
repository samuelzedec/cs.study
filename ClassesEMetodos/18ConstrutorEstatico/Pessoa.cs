namespace _18ConstrutorEstaticos;
public class Pessoa
{
    public static int IdadeMinima;
    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int Idade, string Nome)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        this.Idade = Idade;
        this.Nome = Nome;
    }

    public Pessoa() { }

    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estático");
        Console.WriteLine("\nInicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }
}
