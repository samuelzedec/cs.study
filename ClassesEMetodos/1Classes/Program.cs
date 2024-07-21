class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Classes e Metodos ##\n");

        Pessoa p1 = new()
        {
            nome = "Samuel",
            idade = 18,
            sexo = "Prefiro Mulher"
        };

        // Pessoa p2 = new Pessoa()
        // {
        //     nome = "Samuel",
        //     idade = 18,
        //     sexo = "Prefiro Mulher"
        // };

        // var p2 = new Pessoa();
        // p2.nome = "Samuel";
        // p2.idade = 18;
        // p2.sexo = "Prefiro Mulher";

        Pessoa p2 = p1;
        p2.idade = 15;

        Console.WriteLine($"{p1.nome} | {p1.idade} | {p1.sexo}");
        Console.WriteLine($"{p2.nome} | {p2.idade} | {p2.sexo}");
    }
}
class Pessoa {
    public string? nome;
    public int idade;
    public string? sexo;
}
