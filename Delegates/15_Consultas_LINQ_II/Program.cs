using  _15_Consultas_LINQ_II;
Console.WriteLine("## Consultas LINQ II ##");
var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\nFirst - Localiza o primeiro elemento:");
var primeiro = listaProdutos.First();
Console.WriteLine($"{primeiro.Name} \t{primeiro.Preco:C2}");

Console.WriteLine("\nFirst - Localiza o primeiro elemento usando um criterio de Nome:");
try
{
    var primeiraOcorrencia1 = listaProdutos.First(p => p.Name == "Cadeira ");
    //Caso o produto não exista, ele irá lançar a exceção "InvalidOperationException"
    Console.WriteLine($"{primeiraOcorrencia1.Name} \t{primeiraOcorrencia1.Preco:C2}");
}
catch (InvalidOperationException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\nFirstOrDefault - Localiza o primeiro elemento usando um criterio de Nome:");
var primeiraOcorrencia2 = listaProdutos.FirstOrDefault(p => p.Name == "Cadeira ");
if (primeiraOcorrencia2 is not null)
    Console.WriteLine($"{primeiraOcorrencia2.Name} \t{primeiraOcorrencia2.Preco:C2}");
else
    Console.WriteLine("Valor não encontrado");

Console.WriteLine("\nLast - Localiza o último elemento");
var ultimoProduto = listaProdutos.Last();
Console.WriteLine($"{ultimoProduto.Name} \t{ultimoProduto.Preco:C2}");

Console.WriteLine("\nLastOrDefault - Localiza o ultimo elemento");
var ultimoProduto2 = listaProdutos.LastOrDefault(p => p.Name == "Cadeira ");
if(ultimoProduto2 is not null)
    Console.WriteLine($"{ultimoProduto2.Name} \t{ultimoProduto2.Preco:C2}");
else
    Console.WriteLine("Valor não encontrado");

Console.WriteLine("\nSingle - Localiza o único elemento da sequência usando o critério de Nome");
try
{
    var unicoElemento = listaProdutos.Single(p => p.Name == "Cadeira");
    Console.WriteLine($"{unicoElemento.Name} \t{unicoElemento.Preco:C2}");
}
catch (InvalidOperationException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\nSingle - Localiza o único elemento usando o critério Nome");
var unicoElemento2 = listaProdutos.SingleOrDefault(p => p.Name == "Smart TV");
if(unicoElemento2 is not null)
    Console.WriteLine($"{unicoElemento2.Name} \t{unicoElemento2.Preco:C2}");
else 
    Console.WriteLine("Valor não encontrado");

