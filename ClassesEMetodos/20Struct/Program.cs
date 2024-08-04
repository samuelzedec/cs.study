using _20Struct;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Structs ##\n");

        Cliente cliente = new(Nome:"Maria", Idade: 19);

        Console.WriteLine($"Nome: {cliente.Nome} | Idade: {cliente.Idade}");
    }
}

