// ReSharper disable once CheckNamespace
namespace EX6.Private;
using EX6.Product;
using Message;

public partial class Customer
{
    private string Name = string.Empty;
    private HashSet<Product> Products = new();
    
    private void CheckCustomerName(ref string name)
    {
        while (string.IsNullOrWhiteSpace(name))
        {
            Message.CustomerNameError();
            name = Console.ReadLine() ?? string.Empty;
        }
        Name = name;
    }

    private void ChoiceCustomer(char option)
    {
        switch (option)
        {
            case 'A':
                MenuPurchase();
                break;
            case 'B':
                RemovePurchase();
                break;
            case 'C':
                Message.ReturnToMainMenu();
                break;
            default:
                Message.Incorrect();
                break;
        }
    }

    //Método para calcular o total de itens no carrinho do cliente
    private int ItemsInCart(out int total)
    {
        total = 0;
        foreach (var items in Products) total += items.amount;
        return total;
    }
}