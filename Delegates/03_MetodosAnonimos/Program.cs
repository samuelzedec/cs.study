Console.WriteLine("## Métodos Anônimos ##\n");
List<string?> list = new() { "Maria", "Miriam", "Paulo", "Carlos" };

//Aqui estamos usando uma função anônima para o Find ter seu callback
string? resultado = list.Find(delegate(string nome)
{
    return nome.Equals("Paulo");
});

Console.WriteLine(resultado);

Console.ReadKey();