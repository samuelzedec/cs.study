using _14_Exercicio_Queue;
Console.WriteLine("## Exercício - Queue ##\n");
Queue<Pedido> fila = new();

//Adicionar pedidos a fila
fila.Enqueue(new Pedido(101, 10.0));
fila.Enqueue(new Pedido(201, 20.0));
fila.Enqueue(new Pedido(301, 30.0));

//Exibir o número pedidos da fila
Console.WriteLine($"Número de pedidos na {nameof(fila)}: {fila.Count}\n");

//Processar os pedido da fila
for (int i = fila.Count; i > 0; i--)
{
    //Retirnando o próximo pedido da fila
    var proximo = fila.Dequeue();
    Console.WriteLine($"Processando pedido: {proximo.Numero} \nValor: {proximo.Valor}\n");
}

//Adicionando um pedido a fila
fila.Enqueue(new Pedido(401, 40.0));
fila.Enqueue(new Pedido(501, 50.0));
fila.Enqueue(new Pedido(601, 60.0));

//Localizando pedido específico
int pedido = 501;
var pedidolocalizado = fila.FirstOrDefault(x => x.Numero == pedido);
if (pedidolocalizado != null) Console.WriteLine($"Pedido 501 localizado, valor {pedidolocalizado.Valor}");
else Console.WriteLine("Pedido 501 não localizado");