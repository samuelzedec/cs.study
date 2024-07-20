namespace Identificadores;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Definindo Identificadores ##");

        //Identificadores válidos
        string? nome = null;
        string nomeCompleto = "Samuel Zedec"; 
        int idade = 19;
        int _valor = 10000;

        Console.WriteLine($"Nome {nome ?? "Desconhecido"}");
        Console.WriteLine($"Nome Completo {nomeCompleto}");
        Console.WriteLine($"Idade {idade}");
        Console.WriteLine($"Valor {_valor}");
    }
}
