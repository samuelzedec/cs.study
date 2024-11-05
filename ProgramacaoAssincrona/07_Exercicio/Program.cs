await ExecutaOperacaoAsync();
Console.ReadKey();

static async Task ExecutaOperacaoAsync()
{
    //Criar uma CancellationTokenSource
    var tempo = 10;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));
    //TimeSpan.FromSeconds(tempo) está pegando o valor 10 em segundos e convertendo para 10.000 milissegundos, que é a unidade que o TimeSpan utiliza internamente para representar o tempo.

    Console.WriteLine("\nInciando download...");
    Console.WriteLine($"Cancelando a operação após {tempo} segundos...");

    try
    {
        string destino =
            @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\ProgramacaoAssincrona\07_Exercicio\destino";
        
        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("https://www.macoratti.net/dados/Poesia.txt",
            HttpCompletionOption.ResponseHeadersRead,
            cancellationTokenSource.Token);

        var totalBytes = response.Content.Headers.ContentLength;
        var readBytes = 0L;

        await using var fileStream = new FileStream(destino, FileMode.Create,
            FileAccess.Write); 
        /*
         * Ao usar o await ele está dizendo que é para esperar a operação de FileStream seja concluída
         * E o using é para automaticamente o o FileStream seja fechado após o uso
        */
        await using var contentStream = await response.Content
            .ReadAsStreamAsync(cancellationTokenSource.Token);

        var buffer = new byte[81920];
        int bytesRead;

        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length,
                   cancellationTokenSource.Token)) > 0)
        {
            await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationTokenSource.Token);
            readBytes += bytesRead;
            Console.WriteLine($"Progresso: {readBytes} / {totalBytes}");
        }
    }
    catch (OperationCanceledException e) //É lançada quando uma operção assíncrona é cancelada antes de ser concluída
    {
        if(cancellationTokenSource.IsCancellationRequested) Console.WriteLine($"\nDownload cancelado pelo usuário: {e.Message}");
        else Console.WriteLine("\nO tempo limite para o download foi atingido.");
    }
    catch (HttpRequestException e)
    {
        Console.WriteLine($"Ocorreu um erro de rede: {e.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ocorreu um erro desconhecido: {e.Message}");
    }
    finally
    {
        Console.WriteLine("\nDownload Finalizado...");
    }
}