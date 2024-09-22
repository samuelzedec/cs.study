Console.WriteLine("## Expressões Lambdas ##\n");

List<string?> list = new() { "Maria", "Miriam", "Paulo", "Carlos" };

//Com a expressão lambda o código fica muito mais legível
var resultado = list.FindIndex((name) => name.Equals("Miriam"));

Console.WriteLine($"Índice de Miriam: {resultado}");