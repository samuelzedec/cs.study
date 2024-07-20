class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("## Instrução While ##\n");
        // var num = Convert.ToInt32(Console.ReadLine());

        // while(num > 0) {
        //     Console.WriteLine($"{num} - 1: {num - 1}");
        //     num--;
        // }

        // Console.Write("Informe um número: ");
        // int x = Convert.ToInt32(Console.ReadLine());
        // int i = 1;

        // if(x > 0) {
        //     while(i <= 10) {
        //         Console.WriteLine($"{x} * {i} = {x * i}");
        //         i++;
        //     }
        // } else {
        //     Console.WriteLine("Numero Inválido...");
        // }

        // while(!false) {
        //     Console.Write("Informe um número inteiro (para sair informe -1) : ");
        //     int num = Convert.ToInt32(Console.ReadLine());
            
        //     if(num == -1) break;

        //     string validar = num % 2 == 1 ? "impar" : "par";
        //     Console.WriteLine($"O número que você informou é {validar}");
        // }

        int x = 0;
        while(x < 5) {
            int y = 0;
            while(y < 5) {
                Console.WriteLine($"({x}, {y}) ");
                y++;
            }
            x++;
            Console.WriteLine();
        }
    }
}