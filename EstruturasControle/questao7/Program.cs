class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 7 ##\n");

        for(int i = 0; i <= 4; i++) {
            for(int j = 0; j < i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}