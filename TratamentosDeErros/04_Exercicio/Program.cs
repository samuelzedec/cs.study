using System.Net;
using System.Threading.Channels;

Console.WriteLine("## Exercício ##\n");
try
{
    Console.WriteLine("Acessando o arquivo poesia.txt em https://macoratti.net/dados\n");

    Console.Write("Informe o nome do arquivo: ");
    string? arquivo = Console.ReadLine();

    Console.Write("Informe a url so site: ");
    string? url = Console.ReadLine();

    HttpClient client = new();
    HttpResponseMessage response = client.GetAsync(url + "/" + arquivo).Result;
    
    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("Acesso ao arquivo feito com sucesso!");
        Console.WriteLine($"Código do status: {response.StatusCode}");
        Console.WriteLine($"Código do status: {(int)response.StatusCode}");
    }
    else
    {
        throw new HttpRequestException($"Erro: {(int)response.StatusCode}");
    }
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada!");
}
catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    Console.WriteLine("Acesso não autorizado");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Requisição inválida");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro interno no servidor");
}
catch (Exception ex)
{
    Console.Write("Erro: ");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("\nProcessamento concluído");
}