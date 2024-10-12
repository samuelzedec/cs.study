namespace Class.Database;
using GlobalMessage;
using MyException;

public partial class Database
{
    public void DeleteRepository()
    {
        var directories = MainDirectory.GetDirectories();
        if (directories.Length == 0) 
            throw new DoesNotExistRepositoryException();
        
        GlobalMessage.DeletingRepository(directories);
        var intValidate = int.TryParse(Console.ReadLine(), out int index);
        if (!intValidate) throw new FormatException();
        --index;
        
        if (index > directories.Length || index < 0)
            throw new ErrorMessageInRepository("Não há repositório com esse índice! \u001b[30m(E1003)\u001b[0m");
        
        GlobalMessage.ConfirmationDeleteRepository(directories[index]);
        Console.Write("\u001b[31mDeseja deletar o diretório (S/N): \u001b[0m");
        var choice = Console.ReadKey().KeyChar;
        choice = char.ToLower(choice);

        if (choice == 's')
        {
            directories[index].Delete(true);
            GlobalMessage.RepositoryDeleteWithSuccess();
        }
        
        if(choice != 's')
            throw new ErrorMessageInRepository("Diretório não excluído! \u001b[30m(E1004)\u001b[0m");
    }
}