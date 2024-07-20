class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Entrada de Dados");

        Console.WriteLine("\nInforme o seu nome");
        string? nome = Console.ReadLine();

        Console.WriteLine("\nInforme sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Seu nome é: {nome}");
        Console.WriteLine($"Sua idade é {idade}");
        Console.ReadKey();
    }
}