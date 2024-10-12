namespace Class.Database;

using GlobalMessage;
using MyException;
using HandlingException;
using System.Diagnostics;

public partial class Database : Handling
{
    private readonly DirectoryInfo MainDirectory;
    private DirectoryInfo Subdirectory;
    private Process Processing;

    public Database()
    {
        //Irei usar está pasta para manipular os documentos, caso queira testar em sua máquina terá que mudar manualmente
        MainDirectory = new(@"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\Praticas\EX11\DefaultDirectory");
        Subdirectory = null;
        Processing = null;
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

    private void ActionDoneInDirector()
    {
        char chosenAction;
        do
        {
            GlobalMessage.DirectoryMenu(Subdirectory.FullName);
            chosenAction = Console.ReadKey().KeyChar;
            
            HandlingMyExceptions(chosenAction, DirectorySecondaryMenu);
        } while (chosenAction is not '5');
    }

    private void DirectorySecondaryMenu(char choice)
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
                CreateFile();
                break;
            case '5':
                GlobalMessage.BackToMainMenu();
                break;
            default:
                GlobalMessage.IncorrectChoices();
                break;
        }
    }

    private void Verification()
    {
        var files = Subdirectory.GetFiles();
        if(files.Length == 0) 
            throw new ErrorMessageInRepository("Não há arquivos existentes neste diretório \u001b[30m(E1002)\u001b[0m");
    }
    
    private void ViewFileInformation()
    {
        Verification();
        
        var files = Subdirectory.GetFiles();
        GlobalMessage.FileSpecifications(files);
    }

    private void DeleteFile()
    {
        Verification();
        var files = Subdirectory.GetFiles();
        GlobalMessage.ViewFileNames(files);
        
        var validate = int.TryParse(Console.ReadLine(), out int fileIndex);
        if (!validate) throw new FormatException();
        --fileIndex;
        
        if (fileIndex > files.Length || fileIndex < 0) 
            throw new ErrorMessageInRepository("Não há arquivos com esse índice \u001b[30m(E1003)\u001b[0m");
        
        GlobalMessage.Confirmation(files[fileIndex]);
        
        Console.Write("\u001b[31mDeseja deletar o arquivo (S/N): \u001b[0m");
        var choice = Console.ReadKey().KeyChar;
        choice = char.ToLower(choice);

        if (choice == 's')
        {
            files[fileIndex].Delete();
            GlobalMessage.SuccessFileDelete();
        }
        
        if(choice != 's')
            throw new ErrorMessageInRepository("Arquivo não excluído! \u001b[30m(E1004)\u001b[0m");
    }

    private void EditFile()
    {
        Verification();
        
        GlobalMessage.ReportFile();
        var initialLetters = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(initialLetters))
            throw new ErrorMessageInRepository("Não há arquivos nesse repositóio com essa sigla! \u001b[30m(E1005)\u001b[0m");
  
        var files = Subdirectory.GetFiles($"{initialLetters}*");
        if (files.Length == 0) 
            throw new ErrorMessageInRepository("Não há arquivos nesse repositóio com essa sigla! \u001b[30m(E1005)\u001b[0m");
        
        GlobalMessage.ViewFileNames(files);
        var choice = int.TryParse(Console.ReadLine(), out int indexFile);
        if (!choice)
            throw new FormatException();
        
        --indexFile;
        
        if(indexFile > files.Length || indexFile < 0)
            throw new ErrorMessageInRepository("Não há arquivos com esse índice \u001b[30m(E1003)\u001b[0m");

        OpeningNotepad(files[indexFile]);
    }

    private void OpeningNotepad(FileInfo file)
    {
        GlobalMessage.Notepad();
        
        Processing = new Process();
        Processing.StartInfo.FileName = "notepad.exe";
        Processing.StartInfo.Arguments = $"{file.FullName}";
        Processing.Start();
        
        GlobalMessage.KillNotepad();
    }

    private void CreateFile()
    {
        string[] acronyms = { "AA",  "AB", "AC" };
        
        GlobalMessage.ViewAcronyms(acronyms);
        var acronym = Console.ReadLine()?.ToUpper();

        if (!acronyms.Contains(acronym) || acronym is null)
            throw new ErrorMessageInRepository("Valor incorreto! \u001b[30m(E1006)\u001b[0m");
        
        GlobalMessage.NameFile();
        var nameFile = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nameFile))
            nameFile = GenerateNameForFile(acronym);
        else 
            nameFile = $"{acronym}_{nameFile}";

        if (File.Exists($@"{Subdirectory.FullName}\{nameFile}"))
        {
            GlobalMessage.ExisingFile(nameFile);
            CreateFile();
        }
        
        File.WriteAllText($@"{Subdirectory.FullName}\{nameFile}", String.Empty);
        GlobalMessage.SuccessFileCreate();
    }

    private string GenerateNameForFile(string acronym)
    {
        var seed = new Random(Guid
                .NewGuid()
                .GetHashCode())
            .Next(1000, 10000);

        return $"{acronym}_file{seed}";
    }
}