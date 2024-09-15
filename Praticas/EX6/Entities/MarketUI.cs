namespace EX6.Private;

public static partial class Market
{
    public static void MarketMainMenu()
    {
        char option;
        do
        {
            Message.MarketMainMenu();
            option = Console.ReadKey().KeyChar;
            option = Char.ToUpper(option);
            ChoiceMarket(option);
        } while (option != 'F');
    }

    private static void ChoiceMarket(char choice)
    {
        switch (choice)
        {
            case 'A':
                AddItemToInventory();
                break;
            case 'B':
                AddCustomer();
                break;
            case 'C':
                ServeCustomer();
                break;
            case 'D':
                SeeBuyers();
                break;
            case 'E':
                ViewProducts();
                break;
            case 'F':
                Message.ToGoBack();
                break;
            default:
                Message.Error();
                break;
            
        }
    }

}