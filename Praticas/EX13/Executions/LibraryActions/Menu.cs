using CustomExceptions;
using Executions.Menu;
using Messages.Library;
using Enums;
using Message.Global;
using Executions.Menu.BookActions;
namespace Executions.LibraryActions;

public static partial class MenuLibrary
{
    private static void Validation()
    {
        var library = Database.Library;
        LibraryMessages.ValidateName();
        
        HandlingCustomExceptions.Format(out int password);
        
        if (!(library.Password == password)) 
            throw new IncorrectPasswordException("Senha incorreta!");
        
    }
    public static void Home()
    {
        Validation();
        ChoiceLibrary option;
        do
        { 
            LibraryMessages.MenuMessages(Database.Library.Name);
            HandlingCustomExceptions.Format(out int value);
            
            option = Enum.IsDefined(typeof(ChoiceLibrary), value)
                ? (ChoiceLibrary)value
                : ChoiceLibrary.InvalidValue;
            HandlingCustomExceptions.TreatingCases(option, DirectingCases);
        } while (option != ChoiceLibrary.ToGoBack);
    }

    private static void DirectingCases(ChoiceLibrary value)
    {
        switch (value)
        {
            case ChoiceLibrary.ViewInformation:
                ViewInformationMethod();
                break;
            case ChoiceLibrary.ServeCustomer:
                LookingForBuyers();
                break;
            case ChoiceLibrary.ViewBilling:
                break;
            case ChoiceLibrary.BookMenu:
                BookMenu.Run();
                break;
            case ChoiceLibrary.ToGoBack:
                GlobalMessages.GoToBack();
                break;
            case ChoiceLibrary.InvalidValue:
                GlobalMessages.Invalid();
                break;
        }
    }
}