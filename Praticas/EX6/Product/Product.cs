namespace EX6.Product;

public class Product(string ProductName, string Mark, DateTime Validity, decimal Price, int Amount, int Code) : Quantity
{
    private int _amount = Amount;

    public decimal TotalValue()
    {
        return _amount * Price;
    }
    
    public string productName { get { return ProductName; } }
    public string mark { get { return Mark; } }
    public DateTime validity { get { return Validity; } }
    public decimal price { get { return Price; } }

    public int amount
    {
        get { return _amount; }
        set { _amount += value; }
    }

    public override int GetHashCode()
    {
        return Code.GetHashCode();
    }
}