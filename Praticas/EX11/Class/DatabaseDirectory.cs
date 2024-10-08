namespace Class.Database;
using GlobalMessage;
using MyException;
using HandlingException;
public partial class Database : Handling
{
    private readonly DirectoryInfo MainDirectory;
    private DirectoryInfo Subdirectory;

    public Database()
    {
        //Irei usar está pasta para manipular os documentos, caso queira testar em sua máquina terá que mudar manualmente
        MainDirectory = new(@"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\Praticas\EX11\DefaultDirectory");
    }
    
    //Daqui para frente irá ser feitos somente os métodos para o case 1 do DefaultMenu
    public void RepositoryAccess()
    {
        var directories = MainDirectory.GetDirectories();
        if (directories.Length == 0) 
            throw new DoesNotExistRepositoryException();
        
        GlobalMessage.ShowAvailable(directories);
        var choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (choice > directories.Length || choice < 0) 
            throw new ErrorMessageInRepository("Não há repositório com essa numeração \u001b[30m(E1001)\u001b[0m");

        Subdirectory = new DirectoryInfo(directories[choice].FullName);
        ActionDoneInDirector();
    }

    public void ActionDoneInDirector()
    {
        char chosenAction;
        do
        {
            GlobalMessage.DirectoryMenu(Subdirectory.FullName);
            chosenAction = Console.ReadKey().KeyChar;
            
            HandlingMyExceptions(chosenAction, DirectorySecondaryMenu);
        } while (chosenAction is not '3');
    }

    public void DirectorySecondaryMenu(char choice)
    {
        switch (choice)
        {
            case '1':
                break;
            case '2':
                break;
            case '3':
                GlobalMessage.BackToMainMenu();
                break;
            default:
                GlobalMessage.IncorrectChoices();
                break;
        }
    }

    public void ViewFileInformation()
    {
        var files = Subdirectory.GetFiles();
        foreach (var file in files)
        {
            Console.WriteLine($"Nome do arquivo: {file.Name}" +
                              $"\nData de crição: {file.LastAccessTime}" +
                              $"\n");
        }
    }
}