class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Inferência Tipos (var) ##\n");

        var idade = 25;
        var nome = "Maria";
        var salario = 2500.00m;

        Console.WriteLine($"{nome} tem {idade} anos e ganha ${salario}");

        //var limitações
        //var salario = null;
        //var titulo;
        //var salario, imposto, total;

        //Não pode mudar o tipos
        //var num = 10;
        //num = num + 20;
        //num = "Olá";
    }
}