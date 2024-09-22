using _02_MulticastDelegate;
Console.WriteLine("## Multicast Delegate ##\n");

//Criando um delegate com Generics
Metodos<string> max = Message<string>.M1;
/*
 * caso o tipo seja pedido no método, não é preciso usar o <string> no M1 (Exemplo), porque o método puxa automaticamente do delegate
 * Exemplo:
 *       - Declarando la na classe Message:
 *       public static void M1<Type>(Type value) => Console.WriteLine($"({nameof(M1)}) - Type: {typeof(Type)} | Value: {value?.ToString()}");
 *
 *       - Atribuindo a um delegate:
 *       Metodos<string> max = Message.M1;
 */

//Atribuindo mais de um método
max += Message<string>.M2; 
max += Message<string>.M3;

//Chamando os métodos
max("Hello, World!");
/*
 * Vale lembrar que ele irá chamando os métodos como se fosse uma Queue
 * Primeiro método a entrar, será o primeiro a ser chamado
 */

Console.WriteLine();
//Removendo um método do delegate
max -= Message<string>.M3; // Ao remover um método que não esteja no delegate, pode ocorrer uma execeção
max?.Invoke("O método 3 foi removido");

Console.ReadKey();

//Usando delegates com tipos genéricos para teste
public delegate void Metodos<TKey>(TKey value);