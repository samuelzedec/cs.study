internal class Program
{
    public static async Task Main(string[] args)
    {
        await foreach (var mes in GerarMeses())
        {
            Console.WriteLine(mes);
        }
    
        static async IAsyncEnumerable<string> GerarMeses()
        {
            yield return "janeiro";
            yield return "fevereiro";
            await Task.Delay(3000);
            yield return "março";
            yield return "abril";
        }
    }
}


// foreach (var mes in GerarMeses())
// {
//     Console.WriteLine(mes);
// }
// static IEnumerable<string> GerarMeses()
// {
//     yield return "janeiro";
//     yield return "fevereiro";
//     yield return "março";
//     yield return "abril";
// }

/*
 * o yield return só pode ser usado em métodos que retornam um tipo que implementa a interface IEnumerable ou IEnumerator.
 * Isso é uma parte essencial do funcionamento do yield return, pois ele permite a criação de iteradores de forma mais simples e legível.
 */