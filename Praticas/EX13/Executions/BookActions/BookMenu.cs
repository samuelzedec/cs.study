using Entities;
using Enums;
using Message.Global;
using Messages.Library;
namespace Executions.Menu.BookActions;

public static partial class BookMenu
{
    public static void Run()
    {
        ChoiceBook option;
        do
        {
            LibraryMessages.BookMenu();
            HandlingCustomExceptions.Format(out int value);

            option = Enum.IsDefined(typeof(ChoiceBook), value)
                ? (ChoiceBook)value
                : ChoiceBook.InvalidValue;
            
            HandlingCustomExceptions.TreatingCases(option, DirectingCases);
        } while (option != ChoiceBook.GoToBack);
    }
    private static void DirectingCases(ChoiceBook option)
    {
        switch (option)
        {
            case ChoiceBook.SeeRegisteredBooks:
                SeeAllBooks();
                break;
            case ChoiceBook.RegisterNewBook:
                RegisterBook();
                break;
            case ChoiceBook.EditBookInformation:
                break;
            case ChoiceBook.DeleteBook:
                break;
            case ChoiceBook.GoToBack:
                GlobalMessages.GoToBack();
                break;
            case ChoiceBook.InvalidValue:
                GlobalMessages.Invalid();
                break;
        }
    }
}