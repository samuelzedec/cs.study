Console.WriteLine("## Exercício ##\n");

string[] nome = new string[5];
double[] nota = new double[5];

for(int i = 0; i < 5; i++)
{
    Console.Write("Informe o nome do aluno: ");
    nome[i] = Console.ReadLine();

    Console.Write($"Informe a nota de {nome[i]}: ");
    nota[i] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine();
}

foreach(string nomes in nome)
{
    Console.WriteLine($"Nome: {nomes}");
}
Console.WriteLine();

double media = 0;

foreach(double notas in nota)
{
    Console.WriteLine($"Nota: {notas}");
    media += notas;
}

Console.WriteLine($"Media: {media / 5}");