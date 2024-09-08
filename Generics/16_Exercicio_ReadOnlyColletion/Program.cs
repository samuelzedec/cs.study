using System.Collections.ObjectModel;
using _16_Exercicio_ReadOnlyColletion;
Console.WriteLine("## Exemplo ReadOnlyColletion<T> ##\n");

/*
ReadOnlyCollection<ExoPlaneta> exoPlanetas = new(ExoPlaneta.GetExoPlanetas());

//Alterações não permitidas 
// exoPlanetas[0] = "Kleper - 422b";
//exoPlanetas[0] = new ExoPlaneta() { Nome = "Kepler-442b" };

exoPlanetas[0].Nome = "Kleper - 422b";

//Listando o exoPlanetas
foreach (var planeta in exoPlanetas) Console.WriteLine(planeta.Nome);
*/

GerenciaExoPlanetas planet = new();
ReadOnlyCollection<ExoPlaneta> listaPlaneta = new(planet.ExoPlanetas);
//listaPlaneta[0].Nome = "Kleper - 422b";

foreach (var item in listaPlaneta)
{
    Console.WriteLine(item.Nome);
}


