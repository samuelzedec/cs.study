static async void ExecutarAcoesAsync()
{
    Console.WriteLine("Iniciando ação...");
    await Task.Delay(2000); // Espera 2 segundos
    Console.WriteLine("Ação concluída.");
}

ExecutarAcoesAsync();
Console.WriteLine("Continuando a execução do programa...");
