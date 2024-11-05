namespace Entities;

public class Invoicing
{
    public decimal Money { get; private set; }
    public int Sales { get; private set; }
    public List<decimal> History { get; private set; }

    public void AddMoney(decimal value)
    {
        Money += value;
        ++Sales;
        History.Add(value);
    }
}