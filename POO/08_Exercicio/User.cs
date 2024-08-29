namespace DataBase;
using BankAccount;
sealed public partial class User
{
    private string? name;
    public string? Name { get { return name; } }

    private int id;
    public int ID { get { return id; } }

    private CurrentAccount current;
    private SavingsAccount savings;
    private InvestmentAccount investment;

    public User(string? name)
    {
        this.name = name;
        this.id = CreateID();
        this.current = new CurrentAccount();
        this.savings = new SavingsAccount();
        this.investment = new InvestmentAccount();
    }

    private int CreateID()
    {
        var seed = Guid.NewGuid().GetHashCode();
        var number = new Random(seed).Next(1000, 10000);
        return number;
    }

}
