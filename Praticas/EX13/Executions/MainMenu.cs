using Executions.LibraryActions;
using Message.MainMenu;
using Message.Global;
using Enums;
namespace Executions.Menu;

public static class MainMenu
{
    public static void RunMenu()
    {
        MainChoice option;
        var task = Task.Run(() => Database.ReturnDataFromTheDatabaseAsync());
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
                MenuLibrary.Home();
                break;
            case MainChoice.LoginAsACustomer:
                break;
            case MainChoice.Close:
                Close();
                break;
            case MainChoice.InvalidValue:
                GlobalMessages.Invalid();
                break;
        }
    }

    private static void Close()
    {
        Database.SalveData();
        StandardMessages.Close();
    }
}