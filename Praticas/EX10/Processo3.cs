using System.Diagnostics;

namespace EX10;

public class Processo3
{
    /*
     * GetProcesses(): Pode ser menos eficiente se você estiver interessado apenas em um processo
     * específico, pois retorna todos os processos. Não requer parâmetro
     * 
     * GetProcessesByName(): Mais eficiente para buscar processos específicos, pois evita o trabalho de
     * iterar sobre todos os processos. Requer um parâmetro
     */
    private static Process[] processosOcorridos;

    public static void Run()
    {
        // processosOcorridos = Process.GetProcessesByName();
        processosOcorridos = Process.GetProcessesByName("notepad");
        Console.WriteLine($"Numero de processos: {processosOcorridos.Count()}");

        foreach (var process in processosOcorridos)
        {
            Console.WriteLine($"Processo: {process.ProcessName} | ID: {process?.Id}");
        }
    }
    private static void PesquisarNoGoogle(string pesquisa)
    {
        var aplicacao = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
        Process.Start(aplicacao, $"https://www.google.com/search?q={pesquisa}".Replace(' ', '+'));
        // Process.Start(aplicacao, $"{pesquisa}");
    }
}