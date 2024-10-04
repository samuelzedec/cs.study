namespace _15_Consultas_LINQ_II;

public class Produto
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required decimal Preco { get; set; }
    public required int Estoque { get; set; }
    public required string Categoria { get; set; }

    public static List<Produto> GetProdutos()
    {
        List<Produto> produtos = new()
        {
            new Produto {Id = 1, Name = "Camiseta", Preco = 29.99m, Estoque = 50, Categoria = "Roupas"},
            new Produto {Id = 2, Name = "Meia Soc.", Preco = 89.90m, Estoque = 20, Categoria = "Roupas"},
            new Produto {Id = 3, Name = "Calça Jeans", Preco = 89.90m, Estoque = 20, Categoria = "Roupas"},
            new Produto {Id = 4, Name = "Tênis Nike", Preco = 199.99m, Estoque = 10, Categoria = "Calçados"},
            new Produto {Id = 5, Name = "iPhone 15", Preco = 1499.99m, Estoque = 9, Categoria = "Eletrônicos"},
            new Produto {Id = 6, Name = "Macbook Pro m3", Preco = 4599.99m, Estoque = 6, Categoria = "Eletrônicos"},
            new Produto {Id = 7, Name = "Mochila", Preco = 139.90m, Estoque = 30, Categoria = "Acessórios"},
            new Produto {Id = 8, Name = "Relógio", Preco = 399.90m, Estoque = 15, Categoria = "Acessórios"},
            new Produto {Id = 9, Name = "Cadeira", Preco = 799.99m, Estoque = 8, Categoria = "Móveis"},
            new Produto {Id = 10, Name = "Mesa Sala", Preco = 2499.99m, Estoque = 7, Categoria = "Móveis"},
            new Produto {Id = 11, Name = "Smart TV", Preco = 3999.99m, Estoque = 4, Categoria = "Eletrônicos"},
            new Produto {Id = 12, Name = "Cadeira", Preco = 699.99m, Estoque = 4, Categoria = "Móveis"}
        };
        return produtos;
    }
}