using System.Collections.ObjectModel;

Console.WriteLine("## ReadOnlyColletion<T> ##\n");
List<string> planetas = new() { "Mercúrio", "Vênus", "Terra", "Marte" };

ReadOnlyCollection<string> listaPlaneta = new(planetas);
//var novaList = planetas.AsReadOnly();

Console.WriteLine("- Planetas não gasosos do sistema solar:");
Exibir(listaPlaneta);

Console.WriteLine($"\n- Planetas na lista: {listaPlaneta.Count}");

Console.Write("- Júpiter esta na lista: ");
Console.WriteLine(listaPlaneta.Contains("Júpiter") ? "Sim" : "Não");

Console.WriteLine($"- Obtendo o planeta no índice 3: {listaPlaneta[3]}");

Console.WriteLine($"- Índice do planeta Terra: {listaPlaneta.IndexOf("Terra")}");

Console.WriteLine("- Inserido um novo elemento na lista original no índice 4");
planetas.Add("Plutão");

Console.WriteLine("- Exibindo novamente a lista");
Exibir(listaPlaneta);

Console.WriteLine("\n\nCopiando os elementos da coleção para um array unidimensional");
string[] planetasArray = new string[listaPlaneta.Count + 2];
listaPlaneta.CopyTo(planetasArray, 1);
Exibir(planetasArray);

void Exibir<T>(IEnumerable<T> Colletion)
{
    foreach (var planet in Colletion) Console.WriteLine($"    * {nameof(planet)}: \"{planet}\"");
}
