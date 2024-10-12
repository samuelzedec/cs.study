namespace Class.Database;
using GlobalMessage;
using MyException;

public partial class Database
{
    public void CreateRepository()
    {
        GlobalMessage.RepositoryName();
        var name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name)) throw new FormatException();
        
        if (Directory.Exists(MainDirectory.FullName + $@"\{name}"))
            throw new ErrorInRepositoryCreation();

        Directory.CreateDirectory(MainDirectory.FullName + $@"\{name}");
        GlobalMessage.CreationCompleted();
    }
}