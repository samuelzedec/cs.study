Console.WriteLine("## SortedDictionary<TKey, TValue> I e II ##\n");

Console.WriteLine("Criando o SortedDictonary");
SortedDictionary<int, string> brics = new()
{
    { 20, "Brazil" },
    { 10, "China" },
    { 40, "India" },
    { 30, "URSS" }
};

Console.WriteLine("\n-Incluindo o elemento de chave=70 e valor=África do Sul");
if(!brics.ContainsKey(70)) brics.Add(70, "África do Sul");

Console.WriteLine($"\n-Número de pares de chaves(elementos) no dicionácio: {brics.Count}");

Console.WriteLine($"\n-Acessando um elemento pela chave -> 20");
Console.WriteLine($"Chave 20 -> {brics[20]}");

Console.WriteLine("\n-Iterando sobre o SortedDictionary");
foreach (var country in brics)
{
    Console.WriteLine($"Key: {country.Key} - Pais: {country.Value}");
}

Console.WriteLine("\n-Verificando se existe um valor com ContainsValue");
Console.WriteLine($"Existe o valor: 'URSS'? -> {brics.ContainsValue("URSS")}");
Console.WriteLine($"Existe o valor: 'Chile'? -> {brics.ContainsValue("Chile")}");

Console.WriteLine("\n-Obtendo o valor da chave 30 usando o TryGetValue");
if(brics.TryGetValue(30, out string pais))
    Console.WriteLine($"Valor na cahve 30: {pais}");


Console.WriteLine();

Console.ReadKey();