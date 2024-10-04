using System.Net;
using EX7;

Console.WriteLine();
var produtosEmEstoque = Loja.getProdutos();

var categoriasSeparadas = produtosEmEstoque
    .GroupBy(grupo => grupo.Categoria)
    .OrderBy(g => g.Key)
    .Select(p => new
    {
        Categoria = p.Key,
        ProdutosPorCategoria = p
            .OrderBy(prod => prod.Id)
            .Select(prod => new
            {
                Nome = prod.Nome,
                ID = prod.Id,
                Preco = prod.Preco,
                EmEstoque = prod.Estoque
            })
    });

// foreach (var item in categoriasSeparadas)
// {
//     Console.WriteLine($"\nCategoria: {item.Categoria} - Produtos: {item.ProdutosPorCategoria.Count()}");
//     foreach (var produto in item.ProdutosPorCategoria)
//         Console.WriteLine($"- {produto.ID}\t{produto.Nome}\t{produto.Preco}\t{produto.EmEstoque}");
// }

var celulares = produtosEmEstoque
    .Where(p => p.Id.Contains("SP"))
    .Select(p => new
    {
        Nome = p.Nome,
        Preco = p.Preco,
        Estoque = p.Estoque
    });

foreach (var celular in celulares)
    Console.WriteLine($"- {celular.Nome}\t{celular.Preco}\t{celular.Estoque}");

var melhorNotebook = produtosEmEstoque.FirstOrDefault(p => p.Nome == "Laptop Gaming");
Console.WriteLine("\nMelhor notebook para jogos:");
Console.WriteLine($"{melhorNotebook?.Nome}\t{melhorNotebook?.Preco}\t{melhorNotebook?.Estoque}");


var orgnizado = produtosEmEstoque
    .Where(p => p.Categoria == "Smartphones")
    .OrderBy(p => p.Categoria)
    .ThenBy(p => p.Preco)
    .Select(p => new
    {
        Nome = p.Nome,
        Preco = p.Preco,
        Estoque = p.Estoque
    });

Console.WriteLine("\nCelulares ordenados por preço:");
foreach (var item in orgnizado)
{
    Console.WriteLine($"{item.Nome}\t{item.Preco}\t{item.Estoque}");
}
    