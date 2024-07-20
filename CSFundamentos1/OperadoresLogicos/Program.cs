class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Operadores Lógicos ##\n");

        bool c1 = 5 >= 7;
        bool c2 = 9 != 8;
        bool resultado;
        Console.WriteLine($"Valor de C1 = {c1} || Valor de C2 = {c2}");
        resultado = c1 && c2;
        Console.WriteLine($"Operador AND: c1 && c2 = {resultado}");
        resultado = c1 || c2;
        Console.WriteLine($"Operador OR: c1 || c2 = {resultado}");
        resultado = !(c1 && c2);
        Console.WriteLine($"Operador NOT: !(c1 && c2) = {resultado}");
    }
}