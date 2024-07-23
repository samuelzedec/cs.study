class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Métodos Estáticos ##\n");

        Console.WriteLine(Calculadora.Somar(4, 6));
        Console.WriteLine(Calculadora.Subtrair(4, 6));
        Console.WriteLine(Calculadora.Dividir(6, 4));
        Console.WriteLine(Calculadora.Multiplicar(4, 6));

    }
}

public class Calculadora
{
    public static int Somar(int n1, int n2) {
        return n1 + n2;
    }

    public static int Subtrair(int n1, int n2) {
        return n1 - n2;
    }

    public static int Multiplicar(int n1, int n2) {
        return n1 * n2;
    }

    public static int Dividir(int n1, int n2) {
        return n1 / n2;
    }
}