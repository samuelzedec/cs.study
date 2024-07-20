class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Instrução break e continue ##\n");

        // for( ; ;) {
        //     Console.Write("Informe uma letra (X = Sair): ");
        //     string? opcao = Console.ReadLine();

        //     Console.WriteLine($"Letra maiúscula: {opcao?.ToUpper()}");

        //     if(opcao == "x" || opcao == "X") {
        //         Console.WriteLine("tchau!");
        //         break;
        //     }
        // }

        // for(int i = 1; i <= 10; i++) {
        //     if(i == 4) {
        //         continue;
        //     }

        //     Console.WriteLine(i);
        // }

        // Console.WriteLine("Informe um numero inteiro");
        // int num = Convert.ToInt32(Console.ReadLine());

        // for(int i = num - 1; i > 0; i--) {
        //     num *= i;
        // }

        // Console.WriteLine(num);

        int n = 1;
        while(n <= 10) {
            if(n == 5) {
                n += 1;
                continue;
            }

            if(n > 8) {
                break;
            }

            Console.WriteLine($"n = {n}");
            n++;
        }
    }
}