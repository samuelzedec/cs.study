class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Operador Uniário e Ternário ##\n");

        // var n = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"O valor oposto de {n} é {-n}");

        // Console.Write("Informe a temperatura: ");
        // var temp = Convert.ToInt32(Console.ReadLine());

        // var resultado = temp > 27 ? "Quente" : "Normal";
        // Console.WriteLine($"Temperatura {resultado}");

        Console.Write("Informe o valor de X: ");
        var x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor de Y: ");
        var y = Convert.ToInt32(Console.ReadLine());

        var resul = x > y ? "X é maior que Y" : 
                    x < y ? "Y é maior que X" :
                    x == y ? "X e Y são Iguais" : "Sem resultado";
        Console.WriteLine(resul);

        Console.ReadKey();
    }
}