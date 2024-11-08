Console.WriteLine("Tratamento de exceção na programação assíncrona");
/*await LancaExceptionAsync();
static async Task LancaExceptionAsync()
{
    try
    {
        var primeiraTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente.");
        });
        await primeiraTask;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Bloco catch executado");
        Console.WriteLine(ex.Message);
    }
}*/
TesteAsync t = new();
await t.ChamaTarefaAsync();
Console.WriteLine("\u001b[31mAcho que ocorreu um erro\u001b[0m");

public class TesteAsync
{
    public Task MinhaTarefaAsync()
    {
        return Task.Run(delegate()
        {
            Task.Delay(2000);
            throw new Exception("Minha Exceção");
        });
    }

    public async Task ChamaTarefaAsync()
    {
        try
        {
            await MinhaTarefaAsync();
        }
        catch (Exception)
        {
            Console.WriteLine("Chegou aquiii");
        }

    }
}