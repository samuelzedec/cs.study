namespace BankAccount;

internal class CurrentAccount
{
    protected decimal money = 0;
    public decimal Money { get { return money; } }
    protected virtual void Deposit()
    {
        try
        {
            Console.Clear();
            Console.Write("Informe o valor que deseja depositar: ");
            money += Convert.ToDecimal(Console.ReadLine());
        } catch(Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex?.StackTrace?.ToString());
            Console.Write("\n\nPressione Enter para continuar...");
            Console.ReadKey();
        }
    } 

    protected virtual void Withdraw()
    {
        try
        {
            Console.Clear();
            Console.Write("Informe o valor que deseja sacar: ");
            money -= Convert.ToDecimal(Console.ReadLine());
        }
        catch (Exception ex) 
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex?.StackTrace?.ToString());
            Console.Write("\n\nPressione Enter para continuar...");
            Console.ReadKey();
        }
    }

    public void getDeposit()
        => Deposit();

    public void getWithdraw() 
        => Withdraw();
}

internal class SavingsAccount : CurrentAccount
{
    protected override void Deposit()
    {
        try
        {
            Console.Clear();
            Console.Write("Informe o valor que deseja depositar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            money += amount + (amount * 0.005m);
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex?.StackTrace?.ToString());
            Console.Write("\n\nPressione Enter para continuar...");
            Console.ReadKey();
        }
    }

    protected override void Withdraw()
    {
        try
        {
            Console.Clear();
            Console.Write("Informe o valor que deseja sacar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if(amount > money) 
            {
                Console.WriteLine("Saldo Insuficiente para saque...\nPressione Enter para continuar...");
                Console.ReadKey();
            } else
            {
                Console.Clear();
                Console.Write("Saldo Sacado com sucesso! \nPressione Enter para continuar...");
                money -= amount;
                Console.ReadKey();
            }
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex?.StackTrace?.ToString());
            Console.Write("\n\nPressione Enter para continuar...");
            Console.ReadKey();
        }
    } 
}

internal class InvestmentAccount : CurrentAccount
{
    protected override void Deposit()
    {
        try
        {
            Console.Clear();
            Console.Write("Informe o valor que deseja depositar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            money += amount + (amount * 0.009m);
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex?.StackTrace?.ToString());
            Console.Write("\n\nPressione Enter para continuar...");
            Console.ReadKey();
        }
    }

    protected override void Withdraw()
    {
        try
        {
            Console.Clear();
            Console.Write("Informe o valor que deseja sacar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount + (amount - 0.001m) > money)
            {
                Console.WriteLine("Saldo Insuficiente para saque...\nPressione Enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.Write("Saldo Sacado com sucesso! \nPressione Enter para continuar...");
                money -= amount + (amount - 0.001m);
                Console.ReadKey();
            }
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex?.StackTrace?.ToString());
            Console.Write("\n\nPressione Enter para continuar...");
            Console.ReadKey();
        }
    }
}

