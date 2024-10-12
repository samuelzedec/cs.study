namespace Class.Menu;
using GlobalMessage;
using Database;
using HandlingException;

public class DefaultMenu : Handling
{
    private readonly Database Database = new();
    public void ToStart()
    {
        GlobalMessage.Welcome();
        char userDecision;
        
        do
        {
            GlobalMessage.DefaultMenuOptions();
            userDecision = Console.ReadKey().KeyChar;
            
            HandlingMyExceptions(userDecision, DirectingUserChoice);
        } while (userDecision is not '4');
    }
    
    private void DirectingUserChoice(char choice)
    {
        switch (choice)
        {
            case '1':
                Database.RepositoryAccess();
                break;
            case '2':
                Database.CreateRepository();
                break;
            case '3':
                Database.DeleteRepository();
                break;
            case '4':
                GlobalMessage.EndProgram();
                break;
            default:
                GlobalMessage.IncorrectChoices();
                break;
        }
    }
}