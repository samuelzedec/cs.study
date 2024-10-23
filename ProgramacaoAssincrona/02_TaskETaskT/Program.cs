using _02_TaskETaskT;
Console.WriteLine("## Café da manhã Síncrono");
CafeDaManha();
Console.Read();
Console.Clear();

Console.WriteLine("## Café da manhã Assíncrono");
CafeDaManhaAsync();
Console.ReadKey();



static void CafeDaManha()
{
    Console.WriteLine("\n-- Preparar café");
    var cafe = PrepararCafe();

    Console.WriteLine("\n** Prepara pão");
    var pao = PrepararPao();
    ServirCafe(cafe, pao);
}

static async void CafeDaManhaAsync()
{
    Console.WriteLine("\n-- Preparar café");
    var tarefaCafe = PrepararCafeAsync();

    Console.WriteLine("\n** Prepara pão");
    var tarefaPao = PrepararPaoAsync();

    var cafe = await tarefaCafe;
    var pao = await tarefaPao;
    
    ServirCafe(cafe, pao);
}

static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\n>>> Servindo vafé da manhã");
    Thread.Sleep(2000);
    Console.WriteLine(">> Café Servido <<");
}

static Cafe PrepararCafe()
{
    Console.WriteLine("- Fervendo o água");
    Thread.Sleep(2000);
    Console.WriteLine("- Coando o café");
    Thread.Sleep(2500);
    Console.WriteLine("- Adoçando o café");
    return new Cafe();
}

static Pao PrepararPao()
{
    Console.WriteLine("* Partir pão");
    Thread.Sleep(2000);
    Console.WriteLine("* Passar manteiga no pão");
    Thread.Sleep(2000);
    Console.WriteLine("* Tostar pão");
    return new Pao();
}


static async Task<Cafe> PrepararCafeAsync()
{
    Console.WriteLine("- Fervendo o água");
    await Task.Delay(2000);
    Console.WriteLine("- Coando o café");
    await Task.Delay(2500);
    Console.WriteLine("- Adoçando o café");
    return new Cafe();
}

static async Task<Pao> PrepararPaoAsync()
{
    Console.WriteLine("* Partir pão");
    await Task.Delay(2000);
    Console.WriteLine("* Passar manteiga no pão");
    await Task.Delay(2000);
    Console.WriteLine("* Tostar pão");
    return new Pao();
}