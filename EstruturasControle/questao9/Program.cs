class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 9 ##\n");
        int i = 2;

        do {
            int j = 1;
            do {
                Console.WriteLine($"{i} x {j} = {i * j}");
                j++;
            } while(j <= 10);
            Console.WriteLine();
            i++;
        } while(i <= 6);
    }
}