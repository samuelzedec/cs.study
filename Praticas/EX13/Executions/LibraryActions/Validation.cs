using CustomExceptions;
using Entities.Menu;
using Executions.Menu;

namespace Executions.LibraryActions;
using Messages.Library;


public static class Validation
{
    public static void Run()
    {
        Library library = new();
        LibraryMessages.ValidateName();
        
        HandlingCustomExceptions.Format(out int password);
        if (!(library.Password == password)) throw new IncorrectPasswordException("Senha incorreta!");
    }
}