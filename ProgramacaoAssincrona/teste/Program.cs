static async Task ExecutarAcoesAsync()
{
    Console.WriteLine("Iniciando ação...");
    await Task.Delay(2000); // Espera 2 segundos
    Console.WriteLine("Ação concluída.");
}

await ExecutarAcoesAsync();
Console.WriteLine("Continuando a execução do programa...");
