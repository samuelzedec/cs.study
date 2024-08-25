Console.WriteLine("## Métodos Find ##\n");

List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

//Retornará o primeiro elemento q bater com a condição
var fruta1 = frutas.Find(x => x.Contains('n'));
Console.WriteLine(fruta1);

//Retornará o últmo elemento q bater com a condição
var fruta2 = frutas.FindLast(x => x.Contains('a'));
Console.WriteLine(fruta2);

//Retornará o índice do primeiro elemento q bater com a condição
var fruta3 = frutas.FindIndex(x => x.Contains('o'));
Console.WriteLine(fruta3);

//Retornará o indice do último elemento que bater com a condição
var fruta4 = frutas.FindLastIndex(x => x.Contains('P'));
Console.WriteLine(fruta4);

//Retornará todos os elementos q bater com a condição, transformando-as em uma List<T>
var fruta5 = frutas.FindAll(x => x.Contains('n'));
foreach(var fruta in fruta5)
{
    Console.WriteLine(fruta);
}
