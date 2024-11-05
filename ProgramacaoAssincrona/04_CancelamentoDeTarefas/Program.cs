using System.Diagnostics;

namespace _04_CancelamentoDeTarefas;

class Program
{
    // private static CancellationTokenSource _cancellationTokenSource;
    
    internal static async Task Main(string[] args)
    {
        Console.WriteLine("## Cancelamento de tarefas ##");
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        /*
         * O Stopwatch é uma classe do namespace System.Diagnostics em C#, que fornece uma maneira simples e precisa de medir o tempo
         * decorrido em uma operação. Neste contexto específico, ele é utilizado para monitorar quanto tempo leva para completar a operação
         * longa que pode ser cancelada.
         *
         * O método stopwatch.Start() inicia a contagem do tempo. Após isso, o relógio começa a medir o tempo decorrido.
         *
         * O tempo decorrido pode ser acessado usando a propriedade stopwatch.Elapsed, que retorna um objeto TimeSpan representando o tempo
         * total que passou desde que o Stopwatch foi iniciado.
         */

        try
        {
            // _cancellationTokenSource = new();
            // _cancellationTokenSource.Cancel();
            // Console.WriteLine("Cancelamento automático após 2,5 segundos");
            // await ExecutaCancelamentoComTimeoutMetodo(2500);
            // await ExecutaCancelmanentoComTimeout(2500);
            // OperacaoLongaDuracaoCancelavel(100, _cancellationTokenSource.Token);
            //_cancellationTokenSource.Token = Cancellation.Token
            // Console.WriteLine(resultado);
            Console.WriteLine("Cancelamento manual...");
            await CancelamentoManual();
        }
        catch (TaskCanceledException e)
        {
            Console.WriteLine($"Tarefa cancelada: tempo expirado após { stopwatch.Elapsed }");
        }
    }
    
    private static Task<int> OperacaoLongaDuracaoCancelavel(int valor, CancellationToken cancellationToken = default)
    {
        Console.WriteLine("Executou Operação de longa duração");
        Task<int>? task = null;
        task = Task.Run(() =>
        {
            int resultado = 0;
            for (int i = 0; i < valor; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    throw new TaskCanceledException(task);
                /*
                 * Portanto, de forma mais clara o task está recebendo o Task.Run() que é uma ação, ao passar a variável task para TaskCanceledException, você
                 * está simplesmente sinalizando que o erro ocorreu naquela tarefa específica. Isso facilita o tratamento de exceções e o diagnóstico de problemas em situações onde várias tarefas estão sendo executadas simultaneamente!
                 */
                    
                Thread.Sleep(50);
                resultado += 1;
            }
            return resultado;
        });
        return task;
    }

    private static async Task ExecutaCancelmanentoComTimeout(int tempo)
    {
        using (var cancellationTokenSource = new CancellationTokenSource(tempo))
        {
            var resultado = await OperacaoLongaDuracaoCancelavel(100, cancellationTokenSource.Token);
            Console.WriteLine($"Resultado: {resultado}");
        }
    }

    private static async Task ExecutaCancelamentoComTimeoutMetodo(int tempo)
    {
        using (var cancellationTokenSource = new CancellationTokenSource())
        {
            cancellationTokenSource.CancelAfter(2500); 
            var resultado = await OperacaoLongaDuracaoCancelavel(100, cancellationTokenSource.Token); 
            Console.WriteLine($"Resultado: {resultado}");
        }
    }

    private static async Task CancelamentoManual()
    {
        using (var cancellationTokenSource = new CancellationTokenSource())
        {
            var TecladoTask = Task.Run(() =>
            {
                Console.WriteLine("Pressione enter para cancelar");
                Console.ReadKey();
                cancellationTokenSource.Cancel();
            });

            var resultado = await OperacaoLongaDuracaoCancelavel(100, cancellationTokenSource.Token);
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}