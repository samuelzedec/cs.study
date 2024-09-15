using System.ComponentModel;
using System.Threading.Channels;

namespace EX6;

public static class Message
{
    public static void Beginning()
    {
        Console.Clear();
        Console.WriteLine("## Sistema que simula um Mercado ##\n");
        Console.WriteLine("Fiz este sistema para treinar meu conhecimento com Coleções Genéricas da linguagem Csharp");
        Continue();
    }

    public static void Continue()
    {
        Console.Write("Pressione enter para continuar...");
        Console.ReadKey();
    }

    public static void Error()
    {
        Console.Clear();
        Console.WriteLine("Escolha uma opção válida!");
        Continue();
    }

    public static void ToGoBack()
    {
        Console.Clear();
        Console.WriteLine("Voltando ao menu anterior!");
        Continue();
    }


    //Essas mensagens serão criadas para a parte da Classe Cliente
    public static void CustomerCheckName()
    {
        Console.Clear();
        Console.Write("Informe seu primeiro nome: ");
    }

    public static void CustomerCheckNameError()
    {
        Console.Clear();
        Console.WriteLine("Você não inseriu um único caracter!");
        Console.Write("Informe novamente seu nome: ");
    }
    public static void CustomerHomeMenu(string name, int item)
    {
        Console.Clear();
        Console.WriteLine($"Olá {name}! O que você deseja fazer: ");
        Console.WriteLine($"Itens no carrinho: {item}");
        Console.WriteLine("[A] - Fazer compra");
        Console.WriteLine("[B] - Remover compra");
        Console.WriteLine("[C] - Voltar ao menu inicial");
        Console.Write("\n> ");
    }
    
    //Lista de produtos disponíveis para o cliente
    private static void ItemInStock(SortedDictionary<int, Product.Product> list)
    {
        var List = list.Values;
        foreach (var item in List) Console.WriteLine($"Produto: {item.productName} - Mark: {item.mark} - Preço: {item.price:C} ({item.hash})");
    }

    public static void ChoiceProducts(SortedDictionary<int, Product.Product> Items)
    {
        Console.Clear();
        Console.WriteLine("Informe o código do produto que você deseja comprar: \n");
        ItemInStock(Items);
        Console.WriteLine("\nPressione enter para sair desse menu!");
        Console.Write("\n> ");
    }

    public static void AddProduct(string name, string mark, decimal price)
    {
        Console.Clear();
        Console.WriteLine($"Produto: {name} - Marca: {mark} ({price:C})");
        Console.Write("Quantas unidades você deseja por no carrinho: ");
    }

    public static void ErrorProduct()
    {
        Console.Clear();
        Console.WriteLine("Produto não encontrado!");
        Continue();
    }

    public static void RemoveItemsInCart(List<Product.Product> list)
    {
        Console.Clear();
        Console.WriteLine("Produtos no seu carrinho:\n");
        if (list.Count == 0)
        {
            Console.WriteLine("Você retirou todos os itens do carrinho\n");
        }
        else
        {
            foreach (var item in list) Console.WriteLine($"Produto: {item.productName} - Quantidade: {item.amount} ({item.hash})");

        }
        Console.WriteLine("\nTecle enter para voltar ao menu!");
        Console.Write("Informe o código do produto que deseja retirar: ");
    }

    public static void InfoProduct(string name, DateTime validity, int amount)
    {
        Console.Clear();
        Console.WriteLine("Produto selecionado:");
        Console.WriteLine($"   * Nome: {name} \n   * Validade: {validity} \n   * Quantidade: {amount}");
        Console.Write("Informe quantas unidades você deseja tirar: ");
    }

    public static void ErrorRemove()
    {
        Console.Clear();
        Console.WriteLine("Você não tem itens no carrinho!");
        Continue();
    }
    
    //Mensagens para o Menu do Mercado
    public static void MarketMainMenu()
    {
        Console.Clear();
        Console.WriteLine("Bem-Vindo! O que você deseja fazer:");
        Console.WriteLine("[A] - Adicionar novo produto");
        Console.WriteLine("[B] - Fazer compra");
        Console.WriteLine("[C] - Atender cliente");
        Console.WriteLine("[D] - Ver faturamento");
        Console.WriteLine("[E] - Ver produtos cadastrados");
        Console.WriteLine("[F] - Encerrar");
        Console.Write("\n> ");
    }


    public static Product.Product AddItemToInventory(out int code)
    {
        Console.Clear();
        Console.Write("Informe o nome do produto: ");
        var name = Console.ReadLine() ?? String.Empty;

        Console.Write("Informe a marca do produto: ");
        var mark = Console.ReadLine() ?? String.Empty;

        Console.Write("Informe quantos meses o produto tem de validade: ");
        int date;
        try
        {
            date = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            date = 1;
        }
        
        Console.Write("Informe o preço do produto (0,00): ");
        decimal price;
        try
        {
            price = Convert.ToDecimal(Console.ReadLine());
        }
        catch
        {
            price = 1.10m;
        }
        
        Console.Write("Informe o código do produto (4 dígitos): ");
        int hash;
        try
        {
            hash = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            var seed = Guid.NewGuid().GetHashCode();
            hash = new Random(seed).Next(1000, 10000);
        }

        code = hash;
        return new Product.Product(name, mark, DateTime.Now.AddMonths(date), hash, price);
    }


    public static void Success()
    {
        Console.Clear();
        Console.WriteLine("Produto Adicionado com sucesso ao seu mercado!");
        Continue();
    }

    public static void View(string name, string mark, DateTime validity, decimal price, int hash)
    {
        Console.WriteLine($"Produto: {name} ({hash})");
        Console.WriteLine($"    * Marca: {mark}");
        Console.WriteLine($"    * Validade: {validity.ToShortDateString()}");
        Console.WriteLine($"    * Preço: {price:C}\n");
    }

    public static void SeeBuyers(string name, decimal value) =>
        Console.WriteLine($"Comprador: {name} \n- Compra total: {value:C}\n");

    public static void CustomerServed(string name, decimal price)
    {
        Console.Clear();
        Console.WriteLine("Atendendo cliente:");
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Valor total em compras: {price:C}\n");
        Continue();
    }

    public static void ErrorQueue()
    {
        Console.Clear();
        Console.WriteLine("Não tem ninguém na fila de espera!");
        Continue();
    }
    
    public static void ErrorInvoicing()
    {
        Console.Clear();
        Console.WriteLine("Você ainda não vendeu nada!");
        Continue();
    }

}