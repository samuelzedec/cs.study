internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Campos Estáticos ##\n");
        A a1 = new();
        a1.x = 10;

        A a2 = new();
        a2.x = 20;

        A.y = 100;

        Console.WriteLine($"a1.x = {a1.x} | a2.x = {a2.x} | A.y = {A.y}");

    }
}

public class A 
{
    public int x;
    public static int y;
    //...

}