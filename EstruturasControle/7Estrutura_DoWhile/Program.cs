class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Instrução Do-While ##\n");
        // int i = 1;

        // do {
        //     Console.WriteLine($"Valor de i = {i}");
        //     i++;

        //     if(i == 7) 
        //         break;

        // } while (i <= 10);

        int x = 0;
        do {
            int y = 0;

            do {
                Console.WriteLine($"({x}, {y})");
                y++;
            } while(y < 5);
            
            Console.WriteLine();
            x++;
        } while(x < 5);
    }
}