class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 4 ##\n");

        Console.Write("Informe uma número: ");
        var num = Convert.ToDouble(Console.ReadLine());

        if(num > 0) {
            for(int i = 0; i <= 10; i++) {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}