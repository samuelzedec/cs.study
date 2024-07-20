class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 10 ##\n");

        do {
            Console.Write("Informe a nota do aluno: ");
            int nota = Convert.ToInt32(Console.ReadLine());

            switch(nota) {
                case 10:
                    Console.WriteLine("Nota: A+");
                    break;

                case 9:
                    Console.WriteLine("Nota: A");
                    break;

                case 8:
                case 7:
                    Console.WriteLine("Nota: B");
                    break;

                case 6:
                    Console.WriteLine("Nota: C");
                    break;

                case 5:
                    Console.WriteLine("Nota: E");
                    break;
                
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Nota: F");
                    break;
                
                default:
                    Console.WriteLine("Nota Inválida...");
                    break;
                
            } 

            if(nota < 0 || nota > 10) {
                break;
            }

        }while(!false);
    }
}