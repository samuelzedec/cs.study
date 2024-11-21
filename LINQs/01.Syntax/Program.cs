Console.Clear();
Console.WriteLine("## LINQ ##\n");

List<string> fruits = new() { "banana", "maçã", "pêra", "uva", "mamão" };

// Query Syntax
var query = from fruit in fruits 
            where fruit.Contains('r')
            select fruit;

Console.WriteLine(string.Join(" ", query)); // ao usar o String.Join() ele irá juntar todos os elementos do array em uma string, separando-os por um espaço

// Method Syntax
Func<string, bool> func = f => f.Contains('r');

var method = fruits.Where(f => func(f));
Console.WriteLine(string.Join(" ", method));