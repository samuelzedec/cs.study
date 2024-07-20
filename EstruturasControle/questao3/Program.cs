class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 3 ##\n");

        do {
            Console.WriteLine("Os 10 primeiros números naturais são");
            Console.WriteLine("1 2 3 4 5 6 7 8 9 10");
            int valor = 0;
            for(int i = 1; i <= 10; i++) {
                valor += i;
            }
            Console.WriteLine($"Soma do 10 primeiros: {valor}");

        } while(false);
    }
}