Console.WriteLine("## Múltiplas execeções async ##");
await LancaMultiplasExecoesAsync();
Console.ReadKey();

// static async Task LancaMultiplasExecoesAsync()
// {
//     try
//     {
//         var primeiraTask = Task.Run(() =>
//         {
//             Task.Delay(1000);
//             throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente");
//         });
//
//         var segundaTask = Task.Run(() =>
//         {
//             Task.Delay(1000);
//             throw new InvalidOperationException("IndexOutOfRangeException lançada explicitamente");
//         });
//
//         await Task.WhenAll(primeiraTask, segundaTask);
//         /*
//          * Aguarda as execuções das
//          * tarefas assíncronas em segundo
//          * plano e retorna uma Task
//          */
//     }
//     catch (IndexOutOfRangeException e)
//     {
//         Console.WriteLine(e.Message);
//     }
//     catch (InvalidOperationException e)
//     {
//         Console.WriteLine(e.Message);
//     }
// }
static async Task LancaMultiplasExecoesAsync()
{
    Task? tarefas = null;
    try
    {
        var primeiraTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente");
        });
        var segundaTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new InvalidOperationException("IndexOutOfRangeException lançada explicitamente");
        });
        tarefas = Task.WhenAll(primeiraTask, segundaTask);
        /*
         * Esse método retorna uma Task que é concluída somente quando todas as Tasks passadas
         * como argumento (primeiraTask e segundaTask) forem concluídas. Se
         * alguma dessas tarefas lançar uma exceção, a Task retornada por WhenAll
         * também será marcada como "faulted" (com falha), contendo as exceções das tarefas individuais.
         */ 
        
        await tarefas;
        /*
         * o await suspende a execução até que todas as tarefas (primeiraTask e segundaTask) sejam concluídas.
         * Como ambas as tarefas lançam exceções, tarefas será marcada como "faulted" e, ao fazer await tarefas,
         * uma exceção será lançada, acionando o bloco catch.
         */
    }
    catch
    {
        Console.WriteLine("Ocorreram as seguintes exceções: \n");
        AggregateException TodasException = tarefas.Exception;
        //todo: tarefas.Exception = AggregateException
       /*
         * AggregateException possui a coleção InnerExceptions, que armazena cada exceção lançada individualmente
         * pelas tarefas (primeiraTask e segundaTask).
         * O loop foreach percorre essa coleção, imprimindo o tipo de cada exceção lançada usando ex.GetType().ToString().
         */
        foreach (var ex in TodasException.InnerExceptions)
        {
            Console.WriteLine(ex.GetType().ToString());
        }
    }
}