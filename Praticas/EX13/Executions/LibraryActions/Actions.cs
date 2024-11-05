using CustomExceptions;
using Entities;
using Executions.Menu;
using Message.Global;
using Messages.Library;

namespace Executions.LibraryActions;

public static partial class MenuLibrary
{
    private static void ViewInformationMethod()
    {
        var data = Database.Library;
        LibraryMessages.Information(data.Name, data.Email, data.Password, data.Books.Count);
    }

    private static void LookingForBuyers()
    {
        if (Database.Customers.Count == 0) 
            throw new EmptyQueueException("Não há clientes na fila no momento!");

        var customersWithPurchases = Database.Customers
            .Where(x => x.Books.Count > 0)
            .Select(c => new Buyers(c.Name, c.Email ,c.Books))
            .ToList();
        
        if (customersWithPurchases.Count == 0) 
            throw new EmptyQueueException("Não há clientes na fila no momento!");
        var queue = new Queue<Buyers>(customersWithPurchases);
        ServingBuyers(queue);
    }

    private static void ServingBuyers(Queue<Buyers> buyersList)
    {
        while (buyersList.Count > 0)
        {
            var buyer = buyersList.Dequeue();
        
            var customer = Database.Customers.Find(x => x.Email == buyer.Email);
            customer?.Books.Clear();
        
            decimal value = 0m;
            foreach (var book in buyer.Books) value += book.Price;
            
            Database.Library.TotalRevenue.AddMoney(value);
            LibraryMessages.PurchaseData(buyer.Name, buyer.Email, buyer.Books, value);
        }
    }

    
}