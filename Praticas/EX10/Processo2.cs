using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace EX10;

public class Processo2
{
    public static void Run()
    {
        Console.Write("Pesquisar por: ");
        var pesquisa = Console.ReadLine() ?? "";
        
        if(String.IsNullOrWhiteSpace(pesquisa)) return;
        
        PesquisarNoGoogle(pesquisa);
    }

    private static void PesquisarNoGoogle(string pesquisa)
    {
        var aplicacao = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
        Process.Start(aplicacao, $"https://www.google.com/search?q={pesquisa}".Replace(' ', '+'));
        // Process.Start(aplicacao, $"{pesquisa}");
    }
}