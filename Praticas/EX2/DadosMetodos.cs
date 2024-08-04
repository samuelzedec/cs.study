namespace EX2;

public partial class Dados
{
    private static void Cadastrar(string? Username, string? Useremail, long Usercell, string? Usersenha)
    {
        Nome = Username;
        Email = Useremail;
        Celular = Usercell;
        Senha = Usersenha;
    }

    private static void Depositar()
    {
        Console.Write("\nInforme o valor que deseja: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Informe sua senha: ");
        string? validar = Console.ReadLine();
        if (validar == Senha)
        {
            Saldo += valor;
            Console.WriteLine("Valor depositado com sucesso");
            Console.WriteLine("--------------------------------------------\n");
        }
        else
        {
            Console.WriteLine("Operação cancelada...");
        }
    }

    private static void Sacar()
    {
        Console.WriteLine("<< Lembrando que é aplicado uma taxa de R$5 >>");
        Console.Write("Informe o valor que deseja sacar: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());
        if(valor + 5 > Saldo)
        {
            Console.WriteLine("\nValor Insuficinente na conta!");
        }
        else
        {
            Console.Write("Informe sua senha: ");
            string? validar = Console.ReadLine();
            if(validar == Senha)
            {
                Console.WriteLine("\nValor sacado com sucesso...");
                Saldo -= (valor + 5);
            }
            else
            {
                Console.WriteLine("Operação cancelada...");
            }
        }
        Console.WriteLine("--------------------------------------------\n");
        Console.ReadKey();
    }

    private static void Emprestar()
    {
        Console.WriteLine("<< Aqui haverá juros de 13% em cima do valor total >>");
        Console.Write("Informe quanto você deseja emprestar: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Informe sua senha: ");
        string? validar = Console.ReadLine();

        if (validar == Senha)
        {
            Saldo += valor;
            Divida += valor * 1.13M;

            Console.WriteLine("Valor emprestado com sucesso!");
            Console.WriteLine("--------------------------------------------\n");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Operação cancelada...");
        }

    }

    private static void PagarEmprestimo()
    {
        Console.Write("Informe o valor que você deseja pagar: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());

        if(valor <= Saldo)
        {
            if(valor > Divida || Divida == 0)
            {
                Console.WriteLine("Não há ou o valor está acima do valor da dívida");
            }
            else
            {
                Console.Write("Informe sua senha: ");
                string? validar = Console.ReadLine();

                if (validar == Senha)
                {
                    Console.WriteLine("Valor pago com sucesso!");
                    Saldo -= valor;
                    Divida -= valor;
                }
                else
                {
                    Console.WriteLine("Operação cancelada...");
                }
            }
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente em sua conta! ");
        }
        Console.WriteLine("--------------------------------------------\n");
        Console.ReadKey();
    }

    private static void MudarEmail()
    {
        Console.Write("Informe sua senha: ");
        string? validar = Console.ReadLine();

        if (validar == Senha)
        {
            Console.Write("Informe um novo email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Senha alterada com sucesso");
        }
        else
        {
            Console.WriteLine("Email não confere");
        }
    }

    private static void MudarTelefone()
    {
        Console.Write("Informe sua senha: ");
        string? validar = Console.ReadLine();

        if (validar == Senha)
        {
            Console.Write("Informe um novo número: ");
            Celular = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Telefone alterado com sucesso");
        }
        else
        {
            Console.WriteLine("Senha não confere");
        }
    }

    private static void MudarSenha()
    {
        Console.Write("Informe sua senha: ");
        string? validar = Console.ReadLine();

        if (validar == Senha)
        {
            Console.Write("Informe uma nova senha: ");
            Senha = Console.ReadLine();
            Console.WriteLine("Senha alterada com sucesso");
        }
        else
        {
            Console.WriteLine("Senha não confere");
        }
    }
}