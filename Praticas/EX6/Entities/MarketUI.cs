// ReSharper disable once CheckNamespace
namespace EX6.Public;
using Message;
/*
 * Essa parte da classe foi criada para manter as interações direta com o usuário
 */

public partial class Market 
{
    //Aqui estou pedindo que o usuario insira o nome do mercado
    private static void Name()
    {
        Message.Name();
        string name = Console.ReadLine() ?? string.Empty; 
        CheckName(ref name);
    }

    public static void Menu()
    {
        Name();
        char option;
        do
        {
            Message.MainMenu(MarketName);
            
            //Convertendo o char inserido em uma letra maiúscula
            option = Console.ReadKey().KeyChar;
            option = Char.ToUpper(option);
            
            //Função para tranferir o usuário para a sua escolha
            Choice(option);
            
        } while (option != 'D');

    }
    
}