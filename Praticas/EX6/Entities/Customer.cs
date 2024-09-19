namespace EX6.Private;
using EX6;
using EX6.Product;

public partial class Customer
{
    private string CustomerName = String.Empty;
    private List<Product> ProductsInCart = new();
    private readonly SortedDictionary<int, Product> ProductsInStockMarket;
    
    public Customer(Dictionary<int, Product> list)
    {
        ProductsInStockMarket = new(list);
    }
    
    public Product this[int index] { get { return ProductsInCart[index]; } }
    public string customerName { get { return CustomerName; } }
    public int Size { get { return ProductsInCart.Count; } }

    private void AssignName()
    {
        Message.CustomerCheckName();
        var name = Console.ReadLine() ?? String.Empty;
        CheckName(name);
    }


    private void CheckName(string name)
    {
        while (String.IsNullOrWhiteSpace(name))
        {
            Message.CustomerCheckNameError();
            name = Console.ReadLine() ?? String.Empty;
        }

        CustomerName = name;
    }

    private void ItemsInCart(out int items)
    {
        items = 0;
        foreach (var item in ProductsInCart) items += item.amount;
    }

    //Métodos feitos para adicionar item
    private void AddItemInCart(int code)
    {
        if (code == 0)
        {
            Message.ToGoBack();
            return;
        }

        ProductsInStockMarket.TryGetValue(code, out var item);
        if (item != null) Found(item);
        if (item == null) Message.ErrorProduct();
    }

    private void Found(Product item)
    {
        int quantity;
        Message.AddProduct(item.productName, item.mark, item.price);
        try
        {
            quantity = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            quantity = 0;
        }

        if (quantity <= 0) return;

        if (!ProductsInCart.Any(x => x.Equals(item)))
        {
            item.amount = quantity;
            ProductsInCart.Add(item);
        }
        else
        {
            SearchIndex(item, quantity);
        }
    }

    private void SearchIndex(Product item, int quantity)
    {
        var index = ProductsInCart.FindIndex(x => x.Equals(item));
        ProductsInCart[index].AddQuantity(quantity);
    }
    //Termino dos métodos para adicionar item

    //Métodos para remover item
    private void RemoveItemInCart(int code)
    {
        if (code == 0)
        {
            Message.ToGoBack();
            return;
        }

        ProductsInStockMarket.TryGetValue(code, out var item);
        if (item != null) RemovingFromCart(item);
        if (item == null) Message.ErrorProduct();
    }

    private void RemovingFromCart(Product item)
    {
        int quantity;
        var index = ProductsInCart.FindIndex(x => x.Equals(item));
        if (index == -1)
        {
            Message.ErrorProduct();
            return;
        }
        
        Message.InfoProduct(ProductsInCart[index].productName, ProductsInCart[index].validity, ProductsInCart[index].amount);
        try
        {
            quantity = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            quantity = 0;
        }
        
        Removing(index, quantity);
    }

    private void Removing(int index, int quantity)
    {
        if (quantity == 0) return;
        if (quantity > ProductsInCart[index].amount || quantity == ProductsInCart[index].amount)
        {
            ProductsInCart.RemoveAt(index);
            return;
        }
        if(quantity < ProductsInCart[index].amount) ProductsInCart[index].RemoveQuantity(quantity);
    }
}