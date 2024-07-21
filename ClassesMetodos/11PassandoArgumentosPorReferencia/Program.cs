internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Passando Argumentos por Referência ##\n");
        int x = 20;
        Console.WriteLine($"Valor de X antes de passar pelo método {x}");

        Calculadora cal = new();
        cal.Dobrar(ref x);

        Console.WriteLine($"Valor de X depois de passar pelo método {x}");
    }
}

public class Calculadora
{
    public void Dobrar(ref int y) {
        y *= 2;
        Console.WriteLine($"O valor do parâmetro Y no método dobrar {y}");
    }
}