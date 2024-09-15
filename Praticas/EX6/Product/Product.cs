namespace EX6.Product;

public class Product : Returns
{
    private readonly string ProductName;
    private readonly string Mark;
    private readonly DateTime Validity;
    private int Hash;
    private readonly decimal Price;
    private int Amount = 0;

    public Product(string _productName, string _mark, DateTime _validity, int _hash, decimal _price)
    {
        this.ProductName = _productName;
        this.Mark = _mark;
        this.Validity = _validity;
        this.Hash = _hash;
        this.Price = _price;
    }

    public string productName { get { return ProductName; } }
    public string mark { get { return Mark; } }
    public DateTime validity { get { return Validity; } }

    public int hash
    {
        get { return Hash; }
        set { Hash = value; }
    }
    public decimal price { get { return Price; } }

    public int amount
    {
        get { return Amount; }
        set { Amount = value; }
    }

    public void AddQuantity(int quantity) => Amount += quantity;
    public void RemoveQuantity(int quantity) => Amount -= quantity;
    
    public decimal PricePerUnit() => Price * Amount;

    public override bool Equals(object? obj)
    {
        if (obj is Product item) return Hash.Equals(item.hash);
        return false;
    }
}