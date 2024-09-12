// ReSharper disable once CheckNamespace
namespace EX6.Private;
using Message;

public partial class Customer
{
    public void Menu()
    {
        char option;
        CustomerName();

        do
        {
            ItemsInCart(out int items);
            Message.CustomerMenu(Name, items);
            option = Console.ReadKey().KeyChar;
            option = char.ToUpper(option);
            
            ChoiceCustomer(option);
            
        } while (option != 'C');
    }

    private void CustomerName()
    {
        Message.CustomerName();
        string name = Console.ReadLine() ?? string.Empty;
        CheckCustomerName(ref name);
    }
}