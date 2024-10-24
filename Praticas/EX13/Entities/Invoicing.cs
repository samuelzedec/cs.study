namespace Entities.Money;

public class Invoicing
{
    public decimal Money { get; private set; }
    public int Sales { get; private set; }

    public void AddMoney(decimal value)
    {
        Money += value;
        ++Sales;
    }
}