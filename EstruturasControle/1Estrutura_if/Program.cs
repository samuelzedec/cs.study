class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Instrução IF ##\n");

        Console.WriteLine("Cliente espcial? (S/N)");
        string? resposta = Console.ReadLine()?.ToUpper();

        if(resposta == "S") Console.WriteLine("Cupom de 10%");
    }
}
