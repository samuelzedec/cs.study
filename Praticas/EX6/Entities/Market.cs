namespace EX6.Private;
using Product;
public static partial class Market
{
    private static Dictionary<int, Product> ProductsInStock = new()
    {
        { 1001, new("Feijão", "Dona Dê", DateTime.Now.AddMonths(5), 1001, 8.99m) },
        { 1002, new("Arroz", "Tio João", DateTime.Now.AddMonths(6), 1002, 5.49m) },
        { 1003, new("Macarrão", "Renata", DateTime.Now.AddMonths(8), 1003, 3.99m) },
        { 1004, new("Açúcar", "União", DateTime.Now.AddMonths(12), 1004, 4.29m) },
        { 1005, new("Sal", "Cisne", DateTime.Now.AddMonths(18), 1005, 1.99m) },
        { 1006, new("Café", "Pilão", DateTime.Now.AddMonths(3), 1006, 12.50m) }
    };
    private static Queue<Customer> QueueCustomers = new();
    private static HashSet<Buyers> Invoicing = new();

    private static void AddItemToInventory()
    {
        var product = Message.AddItemToInventory(out int code);

        while (ProductsInStock.ContainsKey(code))
        {
            var seed = Guid.NewGuid().GetHashCode();
            code = new Random(seed).Next(1000, 10000);
        }

        product.hash = code;
        ProductsInStock.TryAdd(code, product);
        Message.Success();
    }

    private static void ViewProducts()
    {
        Console.Clear();
        var products = ProductsInStock.Values;
        foreach (var item in products) Message.View(item.productName, item.mark, item.validity, item.price, item.hash);
        Message.Continue();
    }

    private static void AddCustomer()
    {
        Customer customer = new(ProductsInStock);
        customer.CustomerHomeMenu();
        QueueCustomers.Enqueue(customer);
    }

    private static void SeeBuyers()
    {
        if (Invoicing.Count == 0)
        {
            Message.ErrorInvoicing();
            return;
        } 
        
        Console.Clear();
        Console.WriteLine("Vendas:\n");
        foreach (var buyer in Invoicing) Message.SeeBuyers(buyer.Name, buyer.Invoicing);
        Message.Continue();
    }

    private static void ServeCustomer()
    {
        if (!QueueCustomers.TryDequeue(out var customer))
        {
            Message.ErrorQueue();
            return;
        }

        TotalRevenue(customer, out decimal total);
        Invoicing.Add(new Buyers(customer.customerName, total));
        Message.CustomerServed(customer.customerName, total);
    }

    private static void TotalRevenue(Customer customer, out decimal value)
    {
        value = 0;
        for (int i = 0; i < customer.Size; i++)
        {
            value += customer[i].PricePerUnit();
        }
    }
}