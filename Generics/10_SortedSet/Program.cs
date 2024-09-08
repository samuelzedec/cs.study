Console.WriteLine("## Coleção SortedSet<T> ##\n");
SortedSet<int> numbers = new() { 1, 5, 3, 4, 2 };
ExibirElemento(numbers);

SortedSet<string> fruits = new() { "Uva", "Banana", "Pera", "Kiwi" };
ExibirElemento(fruits);

static void ExibirElemento<T>(IEnumerable<T> list)
{
    foreach (var item in list) Console.WriteLine($"Item: {item}");
}
