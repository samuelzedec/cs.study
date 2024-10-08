namespace Class.MyException;

public class DoesNotExistRepositoryException : Exception
{
    public DoesNotExistRepositoryException() {}
    public override string Message => "\u001b[31mNão há repositórios existentes! Você pode criar um novo...\u001b[0m";
    public override string HelpLink => "Consultar em: https://github.com/samuelzedec";
}

public class ErrorMessageInRepository : Exception
{
    public readonly string Error;
    public ErrorMessageInRepository(string error) { Error = error; }
    public override string Message => $"\u001b[31m{Error}\u001b[0m";
}