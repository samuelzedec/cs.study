namespace EX6.Private;
using EX6;
using EX6.Product;
public partial class Customer
{
    public void CustomerHomeMenu()
    {
        char option;
        AssignName();
        do
        {
            ItemsInCart(out int items);
            Message.CustomerHomeMenu(CustomerName, items);
            
            option = Console.ReadKey().KeyChar;
            option = Char.ToUpper(option);
            
            CustomerChoice(option);
        } while (option != 'C');
    }

    private void CustomerChoice(char choice)
    {
        switch (choice)
        {
            case 'A':
                AddItems();
                break;
            case 'B':
                QuantityCheck();
                break;
            case 'C':
                Message.ToGoBack();
                break;
            default:
                Message.Error();
                break;
        }
    }

    private void AddItems()
    {
        int code;
        do
        {
            Message.ChoiceProducts(ProductsInStockMarket);
            try
            {
                code = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                code = 0;
            }
            AddItemInCart(code);
        } while (code != 0);
    }

    private void QuantityCheck()
    {
        if(ProductsInCart.Count > 0) RemoveProduct();
        else Message.ErrorRemove();
    }


    private void RemoveProduct()
    {
        var code = 0;
        do
        {
            Message.RemoveItemsInCart(ProductsInCart);
            try
            {
                code = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                code = 0;
            }
            
            RemoveItemInCart(code);
            
        } while (code != 0);
    }
}