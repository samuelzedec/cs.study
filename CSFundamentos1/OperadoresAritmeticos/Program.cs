class Program 
{
    static void Main(string[] args) 
    {
        Console.WriteLine("## Operadores Aritméticos ##\n");

        Console.WriteLine("Informe o valor de X:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor de Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine($"soma de x + y = {x + y}");
        // Console.WriteLine($"soma de x - y = {x - y}");
        // Console.WriteLine($"soma de x * y = {x * y}");
        // Console.WriteLine($"soma de x / y = {x / y}");
        // Console.WriteLine($"soma de x % y = {x % y}");

        Console.WriteLine($"\nRaiz quadrada x = {Math.Sqrt(x)}");
        Console.WriteLine($"\nPotência de x elevado a y = {Math.Pow(x, y)}");
        Console.WriteLine($"\nValor mínimo entre x e y = {Math.Min(x, y)}");
        Console.WriteLine($"\nValor máximo entre x e y = {Math.Max(x, y)}");
        Console.WriteLine($"\nCoseno de x = {Math.Cos(x)}");
        Console.WriteLine($"\nSeno de x = {Math.Sin(x)}");
        Console.WriteLine($"\nExponecial de x = {Math.Exp(x)}");

        Console.ReadKey();
    }
}