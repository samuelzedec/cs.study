Console.WriteLine("## Coleção Queue<T> ##\n");

/*Queue<string> semana = new();
semana.Enqueue("Segunda");
semana.Enqueue("Terça");
semana.Enqueue("Quarta");

int[] array1 = { 1, 2, 3, 4, 5 };
Queue<int> numbers = new(array1);

Queue<int> impares = new(3);
impares.Enqueue(1);*/

string[] cursos = { "C#", "Python", "Java", "SQL", "ASP.NET" };
Queue<string> fila1 = new(cursos);

Console.WriteLine($"- Quantidade de elementos na {nameof(fila1)}: {fila1.Count}");
Exibir(fila1);

Console.WriteLine("\n- Adicionando .NET MAUI");
fila1.Enqueue(".NET MAUI");
Exibir(fila1);

Console.WriteLine($"\n- Removendo o primeiro elemento da {nameof(fila1)}");
Console.WriteLine($"     * Elemento: {fila1.Dequeue()}");
Console.WriteLine($"\n- Elemento no início da {nameof(fila1)}: {fila1.Peek()}");

Console.WriteLine($"\n- {nameof(fila1)} contém C#: {fila1.Contains("C#")}");

void Exibir<Type>(IEnumerable<Type> Collection)
{
    foreach (var item in Collection) Console.WriteLine($"     * {nameof(item)}: {item}");
}

