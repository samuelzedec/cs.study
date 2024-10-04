using _16_Consultas_LINQ_III;
Console.WriteLine("## Consultas LINQ III ##");
var produtos = Produto.GetProdutos();

var produtosPorCategoria = produtos
    .GroupBy(p => p.Categoria)
    .OrderBy(p => p.Key)
    .Select(g => new
    {
        Categoria = g.Key,
        Produtos = g
            .OrderBy(p => p.Name)
            .Select(p => new
            {
                Nome = p.Name,
                Preco = p.Preco,
                Estoque = p.Estoque
            })
    });

foreach (var grupo in produtosPorCategoria)
{
    Console.WriteLine($"{grupo.Categoria} : {grupo.Produtos.Count()}");
    foreach (var item in grupo.Produtos)
    {
        Console.WriteLine($"\t{item.Nome}\t{item.Preco}\t{item.Estoque}");
    }
}