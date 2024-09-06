Console.WriteLine("## Dictionary I and II ##\n");
Dictionary<int, int> dic1 = new()
{
    { 1, 100 },
    { 2, 200 },
    { 3, 300 },
    { 9, 900 },
    { 7, 900 }
};

try
{
    dic1.Add(3, 333);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.ReadKey();
Console.Clear();

bool result = dic1.TryAdd(3, 333);
Console.WriteLine($"\nElemento foi incluido -> {result}");

if (!dic1.ContainsKey(8))
{
    var inserido = dic1.TryAdd(8, 700);
    Console.WriteLine($"Valor foi inserido na chave 8 -> {inserido}");
}

Console.WriteLine($"Valor da chave 8 -> {dic1[8]}");

Console.ReadKey();
Console.Clear();

Console.WriteLine("Usando o ContainsValue(200)");
if(dic1.ContainsValue(200))
    Console.WriteLine("O valor existe no Dictionary<TKey, TValue>");
else
    Console.WriteLine("O valor não existe no Dictionary<TKey, TValue>");

Console.ReadKey(); 
Console.Clear();

Console.WriteLine("Alterando valor da chave 7");
Console.WriteLine($"Valor atual da chave 7 -> {dic1[7]}");
if (dic1.ContainsKey(7))
    dic1[7] = 10000;

Console.WriteLine($"Novo valor da key 7 -> {dic1[7]}");

Console.ReadKey(); 
Console.Clear();

Console.WriteLine("Tentando obter um elemento com a chave 5");

try
{
    Console.WriteLine(dic1[5]);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.ReadKey(); 
Console.Clear();

Console.WriteLine("Usando o TryGetValue() para a chav");

if(dic1.TryGetValue(1, out int valor)) Console.WriteLine($"Valor para a chave 1 = {valor}");
else Console.WriteLine("A chave nao existe");


Console.ReadKey(); 
Console.Clear();

Console.WriteLine("Percorrendo um Dictionary<TKey, TValue> com o foreach");

foreach (var item in dic1)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

Console.ReadKey(); 
Console.Clear();

Console.WriteLine("Ordenando os elementos do dicionario(SortedDictionary/LINQ");
//var dicOrdenado = new SortedDictionary<int, int>(dic1);
var dicOrdenado = dic1.OrderBy(x => x.Key);
foreach (var item in dicOrdenado) Console.WriteLine($"{item.Key}: {item.Value}");