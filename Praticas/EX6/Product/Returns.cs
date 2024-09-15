namespace EX6.Product;

public interface Returns
{
    public string productName { get; }
    public string mark { get; }
    public DateTime validity { get; }
    public int hash { get; }
    public decimal price { get; }
    public int amount { get; set; }


    public decimal PricePerUnit();
}