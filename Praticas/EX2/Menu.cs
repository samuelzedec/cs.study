namespace EX2;

public partial class Dados
{
    public static void Cadastrar()
    {
        Console.Write("Informe seu nome completo: ");
        string? nome = Console.ReadLine();

        Console.Write("\nInforme seu Email: ");
        string? email = Console.ReadLine();

        Console.Write("\nInforme seu telefone: ");
        long celular = Convert.ToInt64(Console.ReadLine());

        Console.Write("\nInforme uma senha: ");
        string? senha = Console.ReadLine();

        Console.Write("Confirme sua senha: ");
        string? confirme = Console.ReadLine();

        while (senha != confirme)
        {
            Console.WriteLine("\n<< As Senhas não conferem, digita novamente! >>");
            Console.Write("Informe uma senha: ");
            senha = Console.ReadLine();

            Console.Write("Confirme sua senha: ");
            confirme = Console.ReadLine();
        }
        Console.WriteLine("<< Conta cadastrada com sucesso! >>\n");
        Cadastrar(Username: nome, Useremail: email, Usercell: celular, Usersenha: senha);
    }

    private static string NomePrimario()
    {
        string? primeiroNome = "";
        for (int i = 0; i < Nome?.Length; i++)
        {
            if (Nome[i] == ' ') break;
            primeiroNome += Nome[i];
        }
        return primeiroNome;
    }

    private static string Esconder()
    {
        string? senhaTamanho = "";
        for (int i = 0; i < Senha?.Length; i++)
        {
            senhaTamanho += "*";
        }
        return senhaTamanho;
    }

    public static void MenuPrincipal()
    {
        int escolha;
        do
        {
            string? nomeUser = NomePrimario();
            Console.WriteLine($"Olá {nomeUser}, Seja Bem Vindo!");
            Console.WriteLine($"Saldo em conta: {Saldo.ToString("c")}");
            Console.WriteLine($"Divida de empréstimo: {Divida.ToString("c")}");

            Console.WriteLine($"\nInforme o número da opção que deseja usar");
            Console.WriteLine($"[1] - Ver meus dados");
            Console.WriteLine($"[2] - Depositar");
            Console.WriteLine($"[3] - Sacar");
            Console.WriteLine($"[4] - Emprestar");
            Console.WriteLine($"[5] - Pagar Empréstimo");
            Console.WriteLine($"[6] - Sair");

            try
            {
                Console.Write("\nDigite: ");
                escolha = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"<< Error: {ex.Message} >>");
                Console.WriteLine($"<< {ex?.StackTrace?.ToString()} >>\n");
                escolha = 0;
            }

            EscolhaUser(escolha);
        } while (escolha != 6);
    }

    private static void EscolhaUser(int num)
    {
        switch (num)
        {
            case 1:
                MudarDados();
                break;
            case 2:
                Depositar();
                break;
            case 3:
                Sacar();
                break;
            case 4:
                Emprestar();
                break;
            case 5:
                PagarEmprestimo();
                break;
            case 6:
                Console.WriteLine("Porgrama Encerrado...");
                break;
            default:
                Console.WriteLine("Opção Incorreta...Tente Novamente!");
                break;
        }
    }

    private static void MudarDados()
    {
        int escolha;
        do
        {
            string senhaTamanho = Esconder();
            Console.WriteLine($"\nNome Completo: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefone: {Celular}");
            Console.WriteLine($"Senha: {senhaTamanho}\n");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine($"\nDeseja fazer algo: ");
            Console.WriteLine("[1] - Alterar Email");
            Console.WriteLine("[2] - Alterar Telefone");
            Console.WriteLine("[3] - Alterar Senha");
            Console.WriteLine("[4] - Voltar ao menu");

            try
            {
                Console.Write("\nDigite: ");
                escolha = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"<< Error: {ex.Message} >>");
                Console.WriteLine($"<< {ex?.StackTrace?.ToString()} >>\n");
                escolha = 0;
            }

            switch(escolha)
            {
                case 1:
                    MudarEmail();
                    break;
                case 2:
                    MudarTelefone();
                    break;
                case 3:
                    MudarSenha();
                    break;
                case 4:
                    Console.WriteLine("Voltando ao menu principal\n");
                    break;
                default:
                    Console.WriteLine("Opção incorreta...Informe outro número\n");
                    break;
            }
        } while (escolha != 4);
    }

}
