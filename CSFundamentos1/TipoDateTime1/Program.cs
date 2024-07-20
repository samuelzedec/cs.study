Console.WriteLine("# Struct DateTime ##\n");

DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje: {hoje}\n");

//Extrair informações da data atual
// Console.WriteLine(hoje.Year);
// Console.WriteLine(hoje.Month);
// Console.WriteLine(hoje.Day);
// Console.WriteLine(hoje.Hour);
// Console.WriteLine(hoje.Minute);
// Console.WriteLine(hoje.Second);
// Console.WriteLine(hoje.Millisecond);
// Console.WriteLine(hoje.Year);

//Adicionando valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));

//Obter dia da semana e do ano
Console.WriteLine($"Dia da semana: {hoje.DayOfWeek}");
Console.WriteLine($"Dia da mês: {hoje.DayOfYear}");

//data no formato longo e abreviado
Console.WriteLine($"Data longa: {hoje.ToLongDateString()}");
Console.WriteLine($"Data abreviada: {hoje.ToShortDateString()}");

//Hora no formato longo e abreviado
Console.WriteLine($"Hora longa: {hoje.ToLongTimeString()}");
Console.WriteLine($"Hora abreviada: {hoje.ToShortTimeString()}");

//Criando uma data específica
DateTime dataHoje = new DateTime(2005, 01, 20, 14, 40, 33);
Console.WriteLine(dataHoje);

Console.ReadKey();