using System.Security.Cryptography.X509Certificates;

namespace DataBase;

sealed public partial class User
{
    public void Menu()
    {
        ShortName(out string shortname);
        char choice;

        do
        {
            Console.Clear();
            TotalMoney(out decimal money);

            Console.WriteLine($"Olá {shortname}, Seja Bem-Vindo!");
            Console.WriteLine($"ID da conta: {ID}");
            Console.WriteLine($"Saldo total: {money.ToString("c")}");
            Console.WriteLine("\nInforme qual conta você deseja usar: ");
            Console.WriteLine("A. Conta Corrente");
            Console.WriteLine("B. Conta Poupança");
            Console.WriteLine("C. Conta de Investimentos");
            Console.WriteLine("D. Sair da conta");

            Console.Write("> ");
            choice = Console.ReadKey().KeyChar;
            choice = char .ToUpper(choice);

            CaseUser(choice);

        } while(choice != 'D');
    }

    private void ShortName(out string shortname)
    {
        shortname = "";
        for(int i = 0; i < Name?.Length; i++)
        {
            if (Name[i] == ' ') break;
            shortname += Name[i];
        }
    }

    private void TotalMoney(out decimal totalmoney)
    {
        totalmoney = 0;
        totalmoney += current.Money + savings.Money + investment.Money;
    }

    private void CaseUser(char choice)
    {
        switch (choice) 
        {
            case 'A':
                First();
                break;
            case 'B':
                Second();
                break;
            case 'C':
                Third();
                break;
            case 'D':
                Console.Clear();
                Console.Write("Saindo da sua conta! \nPressione Enter para continuar...");
                break;
            default:
                Console.Clear();
                Console.Write("Informe um valor válido! \nPressione Enter para continuar...");
                break;
        }
    }

    private void Exit()
    {
        Console.Clear();
        Console.Write("Voltando para o menu da sua conta... \nPressione Enter para continuar...");
        Console.ReadKey();
    }
    private void Invalid()
    {
        Console.Clear();
        Console.Write("Informe um valor válido... \nPressione Enter para continuar...");
        Console.ReadKey();
    }
    private void MiniMenu()
    {
        Console.WriteLine("\nInforme o que você deseja fazer na sua conta: ");
        Console.WriteLine("A. Sacar dinheiro");
        Console.WriteLine("B. Depositar Dinheiro");
        Console.WriteLine("C. Voltar");
    }

    private void First()
    {
        char choice;
        do
        {
            Console.Clear();
            Console.WriteLine($"Saldo na conta: {current.Money.ToString("c")}");
            MiniMenu();

            Console.Write("> ");
            choice = Console.ReadKey().KeyChar;
            choice = char.ToUpper(choice);

            FirstCase(choice);

        } while (choice != 'C');
    }

    private void FirstCase(char choice)
    {
        switch(choice)
        {
            case 'A':
                current.getWithdraw();
                break;
            case 'B':
                current.getDeposit();
                break;
            case 'C':
                Exit();
                break;
            default:
                Invalid();
                break;
        }
    }

    private void Second()
    {
        char choice;
        do
        {
            Console.Clear();
            Console.WriteLine($"Saldo na conta: {savings.Money.ToString("c")}");
            MiniMenu();

            Console.Write("> ");
            choice = Console.ReadKey().KeyChar;
            choice = char.ToUpper(choice);

            SecondCase(choice);

        } while (choice != 'C');
    }

    private void SecondCase(char choice)
    {
        switch (choice)
        {
            case 'A':
                savings.getWithdraw();
                break;
            case 'B':
                savings.getDeposit();
                break;
            case 'C':
                Exit();
                break;
            default:
                Invalid();
                break;
        }
    }

    private void Third()
    {
        char choice;
        do
        {
            Console.Clear();
            Console.WriteLine($"Saldo na conta: {investment.Money.ToString("c")}");
            MiniMenu();

            Console.Write("> ");
            choice = Console.ReadKey().KeyChar;
            choice = char.ToUpper(choice);

            ThirdCase(choice);

        } while (choice != 'C');
    }

    private void ThirdCase(char choice)
    {
        switch (choice)
        {
            case 'A':
                investment.getWithdraw();
                break;
            case 'B':
                investment.getDeposit();
                break;
            case 'C':
                Exit();
                break;
            default:
                Invalid();
                break;
        }
    }

}
