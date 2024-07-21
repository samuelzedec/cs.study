class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Métodos com Retorno");

        Calculadora cal = new();
        Console.WriteLine(cal.Somar(4, 6));
        Console.WriteLine(cal.Subtrair(4, 6));
        Console.WriteLine(cal.Dividir(6, 4));
        Console.WriteLine(cal.Multiplicar(4, 6));

    }
}

public class Calculadora
{
    public int Somar(int n1, int n2) {
        return n1 + n2;
    }

    public int Subtrair(int n1, int n2) {
        return n1 - n2;
    }

    public int Multiplicar(int n1, int n2) {
        return n1 * n2;
    }

    public int Dividir(int n1, int n2) {
        return n1 / n2;
    }
}