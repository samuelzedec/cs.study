namespace EX7;

public class Loja
{
    public static List<Produto> getProdutos() 
    {
        List<Produto> produtos = new() 
        {
            new Produto { Id = "SP001", Nome = "Smartphone XYZ", Categoria = "Smartphones", Preco = 1999.99m, Estoque = 50 },
            new Produto { Id = "SP002", Nome = "Smartphone ABC", Categoria = "Smartphones", Preco = 2499.99m, Estoque = 30 },
            new Produto { Id = "SP003", Nome = "Smartphone 123", Categoria = "Smartphones", Preco = 1599.99m, Estoque = 20 },
            new Produto { Id = "SP004", Nome = "Smartphone Pro", Categoria = "Smartphones", Preco = 2999.99m, Estoque = 15 },
            new Produto { Id = "SP005", Nome = "Smartphone Lite", Categoria = "Smartphones", Preco = 1299.99m, Estoque = 40 },
            new Produto { Id = "LP001", Nome = "Laptop Gaming", Categoria = "Laptops", Preco = 4999.99m, Estoque = 10 },
            new Produto { Id = "LP002", Nome = "Laptop Ultrabook", Categoria = "Laptops", Preco = 3499.99m, Estoque = 12 },
            new Produto { Id = "LP003", Nome = "Laptop Empresarial", Categoria = "Laptops", Preco = 2999.99m, Estoque = 8 },
            new Produto { Id = "LP004", Nome = "Laptop 2 em 1", Categoria = "Laptops", Preco = 3999.99m, Estoque = 6 },
            new Produto { Id = "LP005", Nome = "Laptop Básico", Categoria = "Laptops", Preco = 1999.99m, Estoque = 20 },
            new Produto { Id = "AC001", Nome = "Fone de Ouvido Bluetooth", Categoria = "Acessórios", Preco = 199.99m, Estoque = 100 },
            new Produto { Id = "AC002", Nome = "Mouse Gamer", Categoria = "Acessórios", Preco = 299.99m, Estoque = 80 },
            new Produto { Id = "AC003", Nome = "Teclado Mecânico", Categoria = "Acessórios", Preco = 349.99m, Estoque = 40 },
            new Produto { Id = "AC004", Nome = "Carregador Sem Fio", Categoria = "Acessórios", Preco = 99.99m, Estoque = 150 },
            new Produto { Id = "AC005", Nome = "Webcam HD", Categoria = "Acessórios", Preco = 199.99m, Estoque = 60 }
        };

        return produtos;
    }
}
