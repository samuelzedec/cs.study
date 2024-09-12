// ReSharper disable once CheckNamespace
namespace EX6.Private;
using Product;
using Message;

public partial class Customer
{
    private Dictionary<int, Product> ProductsInStock = new()
    {
        { 0001, new("Feijão", "Dona Dê", DateTime.Now.AddMonths(3), 8.99m, 0, 0001) },
        { 0002, new("Arroz", "Tio João", DateTime.Now.AddMonths(6), 10.49m, 0, 0002) },
        { 0003, new("Macarrão", "Renata", DateTime.Now.AddMonths(5), 4.49m, 0, 0003) },
        { 0004, new("Café", "Kimimo", DateTime.Now.AddMonths(7), 16.99m, 0, 0004) },
        { 0005, new("Açucar", "União", DateTime.Now.AddMonths(10), 5.29m, 0, 0005) }
    };

    private void SelectedProduct(int code, int amount)
    {
        if (amount <= 0) throw new ArgumentException();

        ProductsInStock.TryGetValue(code, out var item);

        if (Products.Contains(item))
        {
            Search(amount, code);
        }
        else
        {
            item.amount = amount;
            Products.Add(item);
        }
    }

    private void Search(int code, int amount)
    {
        foreach (var item in Products)
        {
            if (item.GetHashCode() == code) item.amount = amount;
        }
    }

    private void ProductsUI(int code)
    {
        ProductsInStock.TryGetValue(code, out var item);
        byte quantity;
        try
        {
            Message.ProductMenu(item.productName, item.mark, item.price);
            quantity = Convert.ToByte(Console.ReadLine());
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            quantity = 0;
        }
        
        Message.AddItem();
        SelectedProduct(code, quantity);
    }
    
    private void MenuPurchase()
    {
        char option;
        do
        {
            Message.ItemList();
            option = Console.ReadKey().KeyChar;
            option = char.ToUpper(option);
            
            ChoiceItems(option);
        } while (option != 'F');
    }

    private void RemovePurchase()
    {
        int code;
        Message.RemoveItem(ProductsInStock);
        try
        {
            code = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            code = 0;
        }
        Verification(code);
        
    }

    private void Verification(int code)
    {
        int quantity;
        if (Products.Any(x => x.GetHashCode() == code))
        {
            var item = Products.FirstOrDefault(x => x.GetHashCode() == code);
            Message.ItemFound(item.productName, item.amount);

            try
            {
                quantity = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                quantity = 0;
            }
            
            RemoveQuantity(quantity, code);
            
        }
    }

    private void RemoveQuantity(int quantity, int code)
    {
        foreach (var item in Products)
        {
            if (item.GetHashCode() == code)
            {
                item.amount -= quantity;
                break;
            }
        }
    }
    
    private void ChoiceItems(char option) 
    {
        switch(option) 
        {
            case 'A':
                ProductsUI(0001);
                break;            
            case 'B':
                ProductsUI(0002);
                break; 
            case 'C':
                ProductsUI(0003);
                break;  
            case 'D':
                ProductsUI(0004);
                break;
            case 'E':
                ProductsUI(0005);
                break;
            case 'F':
                Message.ReturnToMainMenu();
                break;
            default:
                Message.Incorrect();
                break;
        }
    }
    
    
}