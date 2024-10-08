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
        var validade = int.TryParse(Console.ReadLine(), out int choice);
        if (!validade) throw new FormatException();
        --choice;
        
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
        } while (chosenAction is not '4');
    }

    public void DirectorySecondaryMenu(char choice)
    {
        switch (choice)
        {
            case '1':
                ViewFileInformation();
                break;
            case '2':
                DeleteFile();
                break;
            case '3':
                EditFile();
                break;
            case '4':
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
        if(files.Length == 0) 
            throw new ErrorMessageInRepository("Não há arquivos existentes neste diretório \u001b[30m(E1002)\u001b[0m");
        
        GlobalMessage.FileSpecifications(files);
    }

    public void DeleteFile()
    {
        var files = Subdirectory.GetFiles();
        GlobalMessage.ViewFileNames(files);
        
        var validate = int.TryParse(Console.ReadLine(), out int fileIndex);
        if (!validate) throw new FormatException();
        --fileIndex;
        
        if (fileIndex > files.Length || fileIndex < 0) 
            throw new ErrorMessageInRepository("Não há arquivos com esse índice \u001b[30m(E1003)\u001b[0m");
        
        GlobalMessage.Confirmation(files[fileIndex]);
        
        Console.WriteLine("\u001b[31mDeseja deletar o arquivo (S/N):\u001b[0m");
        var choice = Console.ReadKey().KeyChar;
        choice = char.ToLower(choice);

        if (choice == 's')
        {
            files[fileIndex].Delete();
            GlobalMessage.SuccessFile();
        }
        
        if(choice != 's')
            throw new ErrorMessageInRepository("Arquivo não excluído! \u001b[30m(E1004)\u001b[0m");
    }

    public void EditFile()
    {
        
    }
}