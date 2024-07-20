class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("## Instrução if-else##\n");
        
        // Console.Write("Informe a nota do aluno: ");
        // int nota = Convert.ToInt32(Console.ReadLine());

        // if(nota > 5) {
        //     Console.WriteLine("Aluno aprovado");
        // } else {
        //     Console.WriteLine("Aluno reprovado");
        // }

        Console.Write("Informe o valor de x: \t");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor de y: \t");
        int y = Convert.ToInt32(Console.ReadLine());

        if(x > y) {
            Console.WriteLine("X é maior que Y");
        } else {
            if(y > x) {
                Console.WriteLine("Y é maior que X");
            } else {
                Console.WriteLine("Y e X são iguais");
            }
        }

        Console.ReadKey();
    }
}