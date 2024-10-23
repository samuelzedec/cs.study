Console.WriteLine("## Programação Síncrona Assincrona");

int espera = 4000; //Representa 4000 milisegundos ou 4 segundos

Console.WriteLine("Tecle algo para inciar");
Console.ReadKey();

RealizarTarefa(espera);
Console.WriteLine($"\nTempo gasto {espera / 1000} segundos");
Console.WriteLine("###Fim do processamento...");

static void RealizarTarefa(int i)
{
    Console.WriteLine("\n>>>Iniciando a tarefa...");
    //Task.Delay(TimeSpan.FromSeconds(i));
    Thread.Sleep(i); //= Serve para pausar uma linha de execução thread por um determinado período de tempo
    Console.WriteLine(">>>Tarefa concluida!");
}