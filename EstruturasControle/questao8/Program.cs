class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 8 ##\n");

        Console.Write("Informe um número inteiro: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for(int i = num - 1; i > 0; i--) {
            num *= i;
        }
        Console.WriteLine($"Fatorial: {num}");
    }
}