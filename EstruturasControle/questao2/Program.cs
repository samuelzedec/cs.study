class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 2 ##\n");

        Console.Write("Informe o valor de A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor de B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor de C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = Math.Pow(b, 2) - 4 * a * c;

        if(delta > 0) {
            double x1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
            double x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("Ambas as raízes são reais e diferentes");
            Console.WriteLine($"X1 = {x1}");
            Console.WriteLine($"X2 = {x2}");
            
        } else if(delta == 0) {
            double x1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
            double x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("Ambas as raízes são reais iguais");
            Console.WriteLine($"X1 = {x1}");
            Console.WriteLine($"X2 = {x2}");

        } else {
            Console.WriteLine("As raízes são imaginárias;");
            Console.WriteLine("Sem solução para os números reais");
        }
    }
}