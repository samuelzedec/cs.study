Console.WriteLine("## Exercicio Array Multidimensional ##\n");
string[,] nomes = new string[2, 5];

for(int i = 0; i < nomes.GetLength(0); i++)
{
    for(int j = 0; j < nomes.GetLength(1); j++)
    {
        Console.Write($"Informe o nome do indice [{i}, {j}]: ");
        nomes[i, j] = Console.ReadLine();
        nomes[i, j] = string.IsNullOrWhiteSpace(nomes[i, j]) ? "Nome não informado" : nomes[i, j];
    }
}
 
Console.WriteLine();
foreach(string nome in nomes)
{
    Console.WriteLine($"- {nome}");
}
