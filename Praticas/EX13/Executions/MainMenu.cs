namespace Executions.Menu;
using Message.MainMenu;
using Message.Global;
using Enums;

public static class MainMenu
{
    public static void RunMenu()
    {
        MainChoice option;
        do
        {
            StandardMessages.ToStart();
            HandlingCustomExceptions.Format(out int value);

            /*
            * Aqui estou verificando se é possivel tranforma o valor inserido pelo usuário
            * em uma propriedade do meu enum
            */
            option = Enum.IsDefined(typeof(MainChoice), value) 
                ? (MainChoice)value
                : MainChoice.InvalidValue;
            
            HandlingCustomExceptions.TreatingCases(option, DirectingChoice);
        } while (option != MainChoice.Close);
    }
    
    private static void DirectingChoice(MainChoice option)
    {
        switch(option)
        {
            case MainChoice.AccessAsLibrary:
                break;
            case MainChoice.LoginAsACustomer:
                break;
            case MainChoice.Close:
                StandardMessages.Close();
                break;
            case MainChoice.InvalidValue:
                GlobalMessages.Invalid();
                break;
        }
    }
}