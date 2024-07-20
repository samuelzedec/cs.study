using System;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saída de dados: Formatação");

            int idade = 25;
            string nome = "Maria";

            Console.Write(nome);
            Console.WriteLine(idade);

            // Escreve na mesma linha 'Maria tem 25 anos'
            Console.WriteLine($"{nome} tem {idade} anos");
        }
    }
}
