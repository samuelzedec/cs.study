class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Operadores Incremento e Decremento ##\n");
        int x = 0;
        Console.WriteLine($"X = {x}");
        int resultado = x++ + 10;
        //Nesse caso depois dele resolver a soma, ai ele irá incrementar
        Console.WriteLine($"pré-incremento => {resultado}");
        Console.WriteLine($"Valor de x => {x}\n");

        int y = 0;
        Console.WriteLine($"Y = {y}");
        int result = ++y + 10;
        //Nesse caso ele irá primeiro incrementrar, depois resolver a soma
        Console.WriteLine($"pós-incremento => {result}");
        Console.WriteLine($"Valor de y => {y}");

        Console.ReadKey();
    }
}