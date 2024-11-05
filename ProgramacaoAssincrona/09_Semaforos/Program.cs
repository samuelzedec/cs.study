internal class Program
{
    private static Semaphore _threadPool = new(3, 5);
    private static SemaphoreSlim _semaforoSlim = new(4); 
    public static void Main(string[] args)
    {
        // for (int i = 0; i < 10; i++)
        // {
        //     Thread threadObject = new Thread(new ThreadStart(ProcessarOperacao));
        //     threadObject.Name = $"Thread: {i}";
        //     threadObject.Start();
        // }
        for (int i = 0; i < 6; i++)
        {
            string threadName = $"Thread {i}";
            int espera = 2 + 2 * i;

            var t = new Thread(() => AcessarDatabase(threadName, espera));
            t.Start();
        }
    }
    
    private static void ProcessarOperacao()
    {
        _threadPool.WaitOne();
        Console.WriteLine($"\u001b[32mThread {Thread.CurrentThread.Name} entrou ma sessão crítica...\u001b[0m");
        Thread.Sleep(6000);
        _threadPool.Release();
        Console.WriteLine($"\u001b[31mThread {Thread.CurrentThread.Name} foi liberado\u001b[0m");
        // A propriedade CurrentThread.Name retorna o nome da thread atualmente em execução.
    }

    private static void AcessarDatabase(string name, int seconds)
    {
        Console.WriteLine($"\u001b[34m{name} aguardando acesso ao banco de dados...\u001b[0m");
        _semaforoSlim.Wait();

        Console.WriteLine($"\u001b[32m{name} autorizada a acessar o banco de dados\u001b[0m");
        Thread.Sleep(TimeSpan.FromSeconds(seconds));

        Console.WriteLine($"\u001b[31m{name} concluída...\u001b[0m");
        _semaforoSlim.Release();
    } 
}
/*
 * Métodos da Classe Semaphore
 *
 *      todo: WaitOne()
 *      - Permite a entrada das threads no semáforo.
 *      Este método indica ao semáforo que existe uma thread aguardando a execução e incrementa a contagem dentro do semáforo.
 *
 *      todo: Release()
 *      - Este métod decrementa a contagem do semáforo.
 *      Deve ser cahamdo sempre que um thread for finalizada, ou quando se desejar liberar a thread para que outra
 *      thread possa entrar em execução.
 */
 
 /*
  * Métodos da Classe SemaphoneSlim
  *
  *     todo: Wait()
  *     Bloqueia o thread atual até que possa inserir o thread no SemaphoreSlim
  *
  *     todo: WaitAsync()
  *     Aguarda assincronamente para inserir o thread no SemaphoneSlim
  *
  *     todo: Release()
  *     Deve ser chamado sempre que um thread for finalizado, ou quando se desejar liberar a thread para que outra
  *     thread possa entrar em execução
  */