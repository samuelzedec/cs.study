// ReSharper disable once CheckNamespace
namespace EX6.Message;
/*
 * Classe crirada para poder conter todas as mensagens que serão mostradas ao usuário
 */
using Product;
public static class Message
{
    //Mensagem para o arquivo Program.cs
    public static void Presentation()
    {
        Console.WriteLine("## Mercado ##\n");
        Console.WriteLine("Fiz esse pequeno sistema para testar meus conhecimentos com as coleções da da linguagem C#.");
        Console.Write("Pressione Enter para continuar...");
        Console.ReadKey();
    }

    //Mensagem para o arquivo MarketUI
    public static void Name()
    {
        Console.Clear();
        Console.Write("Informe o nome do seu Mercado: ");
    }

    public static void NameError()
    {
        Console.Clear();
        Console.WriteLine("Nome incorreto, você não inseriu nenhum caracter...");
        Console.Write("Informa novamente o nome do seu mercado: ");
    }

    public static void MainMenu(string name)
    {
        Console.Clear();
        Console.WriteLine($"* Seja Bem-Vindo ao mercado {name}!\n");
        Console.WriteLine("Informe a letra de qual opção deseja acessar: ");
        Console.WriteLine("[A]. Atender clientes");
        Console.WriteLine("[B]. Fazer compra");
        Console.WriteLine("[C]. Ver vendas/faturamento");
        Console.WriteLine("[D]. Encerrar programa");
        Console.Write("\n> ");
    }
    
    public static void Closing()
    {
        Console.Clear();
        Console.WriteLine("\nPrograma encerrado...Obrigado por testar!");
    }

    public static void Incorrect()
    {
        Console.Clear();
        Console.WriteLine("Opção incorreta. Informe uma opção correta para continuar! \nPressione enter para continuar...");
        Console.ReadKey();
    }
    
    //Mensagem para o arquivo CustomerUI
    public static void CustomerName()
    {
        Console.Clear();
        Console.Write("Informe seu nome: ");
    }

    public static void CustomerNameError()
    {
        Console.Clear();
        Console.WriteLine("Você não informou um único caracter...");
        Console.Write("Informe seu nome novamente: ");
    }
    
    public static void CustomerMenu(string name, int item)
    {
        Console.Clear();
        Console.WriteLine($"Bem-Vindo {name}. O que você deseja fazer?");
        Console.WriteLine($"Total de item ao carrinho: {item}\n");
        Console.WriteLine("[A] - Adicionar item ao carrinho");
        Console.WriteLine("[B] - Remover item do carrinho");
        Console.WriteLine("[C] - Sair");
        Console.Write("\n> ");
    }

    public static void ReturnToMainMenu()
    {
        Console.Clear();
        Console.WriteLine("Voltando ao menu inicial! Pressione enter para prosseguir...");
        Console.ReadKey();
    }

    //Mensagens para os produtos
    public static void ItemList()
    {
        Console.Clear();
        Console.WriteLine("Oque você deseja adicionar ao seu carrinho:");
        Console.WriteLine("[A] - Feijão (Dona Dê) - R$ 8,99"); //Code: 0001
        Console.WriteLine("[B] - Arroz (Tio João) - R$ 10,49"); //Code: 0002
        Console.WriteLine("[C] - Macarrão (Renata) - R$ 4,79"); //Code: 0003
        Console.WriteLine("[D] - Café (Pilão) - R$ 16,99"); //Code: 0004
        Console.WriteLine("[E] - Açúcar (União) - R$ 5,29"); //Code: 0005
        Console.WriteLine("[F] - Não adicionar ao carrinho");
        Console.Write("\n> ");
    }
    
    //Mesnagem de cada item
    public static void ProductMenu(string name, string mark, decimal price)
    {
        Console.Clear();
        Console.WriteLine($"Produto: {name} - {mark} ({price:C})");
        Console.Write("Quantidade: ");
    }

    public static void AddItem()
    {
        Console.Clear();
        Console.WriteLine("Quantidade será colocada na lista, caso seja válido!");
        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadKey();
    }

    private static void ListItemRemove(Dictionary<int, Product> Collection)
    {
        int i = 1;
        foreach (var item in Collection)
        {
            Console.WriteLine($"Produto: {item.Value.productName} - Código: 000{i}");
            i++;
        }
    }

    public static void RemoveItem(Dictionary<int, Product> Collection)
    {
        Console.Clear();
        ListItemRemove(Collection);
        Console.Write("\nInforme o código de qual produto você deseja remover: ");
    }

    public static void ItemFound(string name, int total)
    {
        Console.Clear();
        Console.WriteLine($"Quantidade: {total}");
        Console.Write($"Qual a quantidade de feijões que você deseja retirar: ");
    }

}