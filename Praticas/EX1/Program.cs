internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter account number: ");
        Bank.Account = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter account holder: ");
        Bank.Holder = Console.ReadLine();

        Console.Write("Is there na initial deposit (y/n): ");
        string? initial = Console.ReadLine()?.ToLower();
        Bank.ToCheck(initial);

        Bank.Display();

        Bank.Deposit();

        Bank.Withdraw();
        
    }
}

public class Bank
{
    public static decimal Balance;
    public static string? Holder;
    public static int Account;

    public static void ToCheck(string? value) {
        if(value == "y") {
            Console.Write("Enter initial deposit value: ");
            Balance = Convert.ToDecimal(Console.ReadLine());
        } else {
            Console.WriteLine($"Welcome {Holder}\n");
        }
    }

    private static void DisplayPrivate() {
        Console.WriteLine($"Account: {Account}, Holder: {Holder}, Balance: {Balance.ToString("c")}");
        Console.WriteLine(DateTime.Now.ToLongDateString() + "\n");
    }

    public static void Display() {
        Console.WriteLine("\nAccount Data: ");
        DisplayPrivate();
    }

    public static void Deposit() {
        Console.Write("\nEnter a deposit: ");
        Balance += Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Update account data:");
        DisplayPrivate();
    } 

    public static void Withdraw() {
        Console.Write("\nEnter a withdraw value: ");
        Balance -= Convert.ToDecimal(Console.ReadLine()) + 5;
        DisplayPrivate();
    }
}