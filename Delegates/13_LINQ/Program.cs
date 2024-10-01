Console.WriteLine("## LINQ I e II ##\n");

List<string> nomes = new()
{
    "Ana", "Maria", "Pedro", "Lair", "Hugo"
};

// Sintaxe de consulta
Console.WriteLine("Sintaxe de Consulta");
var resultado = 
    from name in nomes 
    where name.Contains("o") 
    select name; 

Exibir(resultado);
/* 
 * O 'from' está criando uma variável temporária que representa cada elemento da lista nome
 * O 'where' está criando uma condição para filtrar elementos
 * Caso o 'where' retorne true para aquele elemento, o 'select' irá pegar esse elemento e jogar na var resultado
 */ 


// Sintaxe de Método
Console.WriteLine("\nSintaxe de Método");
var resultado2 = nomes.Where(n => n.Contains("a"));
Exibir(resultado2);

void Exibir(IEnumerable<string> enumerable)
{
    foreach (var item in enumerable) Console.WriteLine(item);
}