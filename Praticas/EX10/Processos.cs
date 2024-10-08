using System.Diagnostics;
namespace EX10;

public class Processos
{
    private static Process processo;
    public static void Run()
    {
        processo = Process.Start("notepad.exe");
        processo.Kill();
    } 
    /*
     * Primeiro parâmetro: será o arquivo irá ser executado, no caso esse arquivo tem que ser um executável.
     * Segundo parâmetro(opcional): será a ação que esse executavel fará
     *
     * Exemplo: o Bloco de notas abrir ou criar um arquivo txt
     */
    
    /*
     * O Kill so funciona caso o Process.Start() estiver guardo em uma váriavel
     */
    
}