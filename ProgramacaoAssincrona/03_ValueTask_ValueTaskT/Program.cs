Console.WriteLine("## ValueTask e ValueTask<T> ##");
/*Console.WriteLine("\n>> Iniciando uma operação assíncrona....");
await MetodoSemRetornoAsync();

Console.WriteLine("\n>> Iniciando uma operação assíncrona....");
var result = await MetodoRetornaValorAsync(4);
Console.WriteLine($"Resultado: {result}");


static async ValueTask MetodoSemRetornoAsync()
{
    Console.WriteLine("- Método que não retorna valor");
    await Task.Delay(2000);
}

static async ValueTask<int> MetodoRetornaValorAsync(int valor)
{
    Console.WriteLine("- Método que retorna valor");
    await Task.Delay(2000);
    return valor * 2;
}*/

Console.Write("Informe o primeiro numero inteiro: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o segundo numero inteiro: ");
int num2 = Convert.ToInt32(Console.ReadLine());

var soma = await CalcularSoma(num1, num2);

// Muda a cor do texto para amarelo
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\n{num1} + {num2} = {soma}");
// Redefine a cor do texto de volta ao padrão
Console.ResetColor();

/*Console.ReadKey();
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear(); // Limpa a tela para aplicar a nova cor de fundo

Console.WriteLine("Este texto está em um fundo azul.");

// Reseta para as cores padrão
Console.ResetColor();*/

static async ValueTask<int> CalcularSoma(int n1, int n2)
{
    if (n1 == 0 && n2 == 0) return 0;
    return await Task.Run(() => n1 + n2);
    
    // todo: Inicia uma nova tarefa para calcular a soma de n1 e n2 de forma assíncrona.
    // - Task.Run: Cria e inicia uma nova tarefa (task) em um thread separado,
    //   permitindo que a operação de soma seja realizada sem bloquear o thread principal.
    
    // - () => n1 + n2: Esta é uma expressão lambda que define a ação a ser executada
    //   na nova tarefa. Aqui, ela retorna a soma de n1 e n2. (aceita um delegate)
    
    // - await: Aguarda a conclusão da tarefa iniciada por Task.Run. Enquanto isso,
    //   o thread que chamou CalcularSoma pode continuar executando outras operações.
    //  O resultado da soma é retornado após a conclusão da tarefa.
}