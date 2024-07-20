class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 11 ##\n");
        
        Console.Write("Informe o primeiro número: ");
        int numOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o operador (+, -, *, /, %): ");
        string? operador = Console.ReadLine(); 

        Console.Write("Informe o segundo número número: ");
        int numTwo = Convert.ToInt32(Console.ReadLine());

        switch(operador) {
            case "+":
                Console.WriteLine($"Resultado: {numOne + numTwo}");
                break;

            case "-":
                Console.WriteLine($"Resultado: {numOne - numTwo}");
                break;

            case "*":
                Console.WriteLine($"Resultado: {numOne * numTwo}");
                break;

            case "/":
                if(numTwo != 0) {
                    Console.WriteLine($"Resultado: {numOne / numTwo}");
                } else {
                    Console.WriteLine("Não existe divisão por 0");
                }
                break;

            case "%":
                if(numOne > numTwo) {
                    Console.WriteLine($"Resultado: {numOne % numTwo}");
                } else {
                    Console.WriteLine("Não existe o resto");
                }
                break;

            default:
                Console.WriteLine("Operador incorreto...");
                break;
        }
    }
}