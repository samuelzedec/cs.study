using System.Threading.Channels;

Console.WriteLine("## Stack<T> (Last in - First Out) ##\n");
/*Stack<int> numbers = new();
numbers.Push(1);

int[] array1 = new[] { 1, 2, 3, 4 };
Stack<int> pilha = new(array1);*/

Stack<int> numbers = new();
numbers.Push(10);
numbers.Push(20);
numbers.Push(30);
numbers.Push(10);
Console.WriteLine("- Pilha orginal");
Exibir(numbers);

//retorna item sem remover
Console.WriteLine($"\n- Item obtido da pilha (Peek()): {numbers.Peek()}");

//retornar item removendo-o
Console.WriteLine($"- Item removido da pilha (Pop()): {numbers.Pop()}");

//Vendo o tamanho da pilha
Console.WriteLine($"- A pilha original contém {numbers.Count} itens");
Console.WriteLine("- Itens na pilha");
Exibir(numbers);

//Verificando se há o elemento 20
if(numbers.Contains(20)) Console.WriteLine("\n- Item 20 está na pilha");
else Console.WriteLine("\n- Item 20 não está na pilha");

//Copiando a pilha
Console.WriteLine("- Copia a pilha usando o ToArray()");
var copia = numbers.ToArray();
Exibir(copia);

//Limpando a pilha
Console.WriteLine("\n- Limpando a pilha");
numbers.Clear();
Console.WriteLine($"    * A pilha contém: {numbers.Count}");

static void Exibir<Type>(IEnumerable<Type> collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine($"    * item: {item} itens");
    }
}