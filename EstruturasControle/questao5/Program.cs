using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Questão 5 ##\n");
        string? escolha;

        do {
            Console.WriteLine("Qual instrução para sair de um loop?");
            Console.WriteLine("a. quit \nb. continue \nc. break \nd. exit");
            escolha = Console.ReadLine()?.ToLower();
            Console.WriteLine("Informe X para sair");

            switch(escolha) {
                case "a":
                case "b":
                case "d":
                    Console.WriteLine("Resposta Incorreta\n");
                    break;
                case "c":
                    Console.WriteLine("Resposta correta, saindo do loop\n");
                    break;
                case "x":
                    Console.WriteLine("Saindo loop\n");
                    break;
            }

        } while(escolha != "c" && escolha != "x");
    }
}