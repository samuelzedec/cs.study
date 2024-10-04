using _14_Consultas_LINQ_I;
//Delegate para exibir os produtos
Action<IEnumerable<Produto>> exibir = delegate(IEnumerable<Produto> prod)
{
    foreach (var produto in prod)
        Console.WriteLine($"{produto.Name} \t{produto.Preco:C2}");
    /*
     * C2: na expressão a letra "C" é o especificador de formato para moeda.
     * Já o número 2, é o número de casas decimais a serem exibidas
     */
};

//fonte de dados da LINQ
var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\nProdutos eletônicos:");
var produtosEletronicos = listaProdutos
    .Where(x => x.Categoria == "Eletrônicos");
exibir(produtosEletronicos);

Console.WriteLine("\nProdutos mais caros com estoque superior a 5:");
var produtosCarosComEstoque = listaProdutos
    .Where(prod => prod.Preco >= 2000 && prod.Estoque > 5);
exibir(produtosCarosComEstoque);

Console.WriteLine("\nLista de produtos com estoque minimo (< 10) ordenados por nome:");
var minimo = 10;
var produtoEstoqueMinimo = listaProdutos
    .Where(p => p.Estoque < minimo)
    .OrderBy(p => p.Name);
exibir(produtoEstoqueMinimo);

Console.WriteLine("\nProdutos ordenados por categoria e nome:");
var produtosOrdenadosPorCategoriaENome = listaProdutos
    .OrderBy(p => p.Categoria)
    .ThenBy(p => p.Name);

string categoria = String.Empty;
foreach (var produto in produtosOrdenadosPorCategoriaENome)
{
    if (produto.Categoria != categoria)
    {
        Console.WriteLine($"{produto.Categoria}:");
        categoria = produto.Categoria;
    }
    Console.WriteLine($"\t {produto.Name}");
}

Console.WriteLine("\nLista dos nomes do produtos ordenados:");
var nomesDosProdutos = listaProdutos
    .Select(p => p.Name)
    .OrderBy(nome => nome);
foreach (var produto in nomesDosProdutos) Console.WriteLine(produto);

Console.WriteLine("\nProdutos com valor menos que R$ 500 com aumento de 10% ordenados pelo nome:");
var resultado = listaProdutos
    .Where(p => p.Preco < 500)
    .OrderBy(p => p.Name)
    .Select(p => new
    {
        NomeProduto = p.Name.ToUpper(),
        PrecoAumentado = p.Preco * 1.1m
    });
foreach (var item in resultado)
{
    Console.WriteLine($"Nome: {item.NomeProduto} - Novo Preço: {item.PrecoAumentado:C2}");
}

Console.Write("\nValor medio dos produtos eletrônicos: ");
var categoriaMedia = "Eletrônicos";
var mediaPreco = listaProdutos
    .Where(p => p.Categoria == categoriaMedia)
    .Average(p => p.Preco);
Console.WriteLine($"{mediaPreco:C2}");


Console.Write("\nValor total dos produtos em estoque: ");
var total = listaProdutos
    .Where(p => p.Estoque > 0)
    .Sum(p => p.Estoque * p.Preco);
Console.WriteLine(total.ToString("C2"));

Console.Write("Produtos com estoque menor que 10: ");   
var menor = listaProdutos
    .Where(p => p.Estoque < 10)
    .Count();
Console.WriteLine(menor);
