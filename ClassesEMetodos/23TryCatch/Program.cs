internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Divisão de números interios ##");
        Console.WriteLine(" x / y");

        Console.Write("Informe o valor de X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor de Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        try
        {
            int z = x / y;
            Console.WriteLine($"{x} / {y} = {z}");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Não existe divisão por 0, tente outro número...\n");
            Console.WriteLine($"Erro <<< {ex.Message} >>>");
            Console.WriteLine($"Detalhes : {ex?.StackTrace?.ToString()}");
        }
        finally
        {
            Console.WriteLine("Tifuder safado");
        }
    }
}