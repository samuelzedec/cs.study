class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 1 ##\n");

        Console.Write("Informe o primeiro números: ");
        int numOne = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o segundo números: ");
        int numTwo = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Informe o terceio número números: ");
        int numThree = Convert.ToInt32(Console.ReadLine());
        
        if(numOne > numTwo && numOne > numThree) {
            Console.WriteLine("O primeiro número é maior que os outros");
        } else if(numTwo > numOne && numTwo > numThree) {
            Console.WriteLine("O segundo número é maior que os outros");
        } else if(numThree > numOne && numThree > numTwo) {
            Console.WriteLine("O terceiro número é maior que os outros");
        } else {
            Console.WriteLine("Existem números iguais... Tente Novamente");
        }
    }
}