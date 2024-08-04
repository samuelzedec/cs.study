Console.WriteLine("Teste de fatorial");

Console.WriteLine($"fatorial de 0: {Fatorial.FatorialTeste(0)}");
Fatorial.Hello();

public class Fatorial
{
    public static int FatorialTeste(int n)
    {
        if(n == 1 || n == 0)
            return 1;

        return n * FatorialTeste(n - 1);
    }

    public static void Hello() => Console.WriteLine("Hello, World!");
}