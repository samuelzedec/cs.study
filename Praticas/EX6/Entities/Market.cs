// ReSharper disable once CheckNamespace
namespace EX6.Public;
using Message;
using Private;
/*
 * Essa parte da classe ja foi feita para conter os métodos que fazem os processos de escolha do usuário ou verificação de algum dado
 */
public partial class Market
{
    private static string MarketName = string.Empty;
    private static Queue<Customer> Customers = new();
    //Método criado pra verificar se o usuário irá inserir pelo menos um caracter para o nome do seu mercado
    private static void CheckName(ref string name)
    {
        while (string.IsNullOrWhiteSpace(name))
        {
            Message.NameError();
            name = Console.ReadLine() ?? string.Empty;
        }
        MarketName = name;
    }
    
    //Propriedade para que possa ter acesso ao campo MarketName
    public static string marketname { get { return MarketName; } }

    //Aqui está um switch que irá direcionar o usuário para sua devida escolha
    private static void Choice(char option)
    {
        switch (option)
        {
            case 'A':
                break;
            case 'B':
                CreateCustomer();
                break;
            case 'C':
                break;
            case 'D':
                Message.Closing();
                break;
            default:
                Message.Incorrect();
                break;
        }
    }
    
    private static void CreateCustomer()
    {
        Customer customer = new();
        customer.Menu();
        Customers.Enqueue(customer);
    }

}