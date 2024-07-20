class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Instrução if-else-if ##\n");

        Console.Write("Informe a nota do aluno: \t");
        double nota = Convert.ToDouble(Console.ReadLine());

        if(nota < 5) {
            Console.WriteLine("Aluno Reprovado");
        } else if(nota >= 5 && nota < 6) {
            Console.WriteLine("Aluno de Recuperação");
        } else if(nota >= 6 && nota < 9) {
            Console.WriteLine("Aluno aprovado");
        } else if(nota >= 9) {
            Console.WriteLine("Aluno aprovado com sucesso");
        }
    }
}