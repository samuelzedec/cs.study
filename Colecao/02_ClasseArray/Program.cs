Console.WriteLine("## Classe Array ##\n");

string[] nomes = { "Ana", "Maria", "Dinair", "Paulo", "Carlos", "Beatriz" };

Console.WriteLine("Exibindo Array Original...");
ExibirArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do Array...");
Array.Reverse(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nOrdenando o Array...");
Array.Sort(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nLocalizando um item no Array...");
Console.WriteLine("Informe um nome: ");
string? nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if(indice >= 0)
{
    Console.WriteLine($"O nome foi encotrado no indice {indice}");
}
else
{
    Console.WriteLine("Nome não encontrado...");
}


Console.ReadKey();
static void ExibirArray(string[] nomes)
{
    foreach (var i in nomes)
    {
        Console.Write($"{i} ");
    }
}