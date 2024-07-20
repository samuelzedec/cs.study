class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 6 ##\n");

        // for(int i = 10; i <= 20; i++) {
        //     if(i == 16) {
        //         continue;
        //     }

        //     if(i % 2 == 0) {
        //         Console.WriteLine($"Número par: {i}");
        //     }
        // }

        // for(int i = 10; i <= 20; i += 2) {
        //     if(i == 16) {
        //         continue;
        //     }

        //     Console.WriteLine($"Número par: {i}");
        // }

        for(int i = 10; ; i += 2) {
            if(i == 16) {
                continue;
            }

            Console.WriteLine($"Número par: {i}");
            
            if(i == 20) {
                break;
            }
        }
    }
}