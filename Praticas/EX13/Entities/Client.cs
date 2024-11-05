using Interfaces;

namespace Entities;
public class Client : IMandatoryData
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    private string _email;
    public string Email 
    {
        get => _email;
        set => _email = value;
    }

    private string _password;
    public string Password 
    {
        get => _password;
        set => _password = value;
    }

    private List<Book> _books;
    public List<Book> Books
    {
        get => _books;
        set => _books = value;
    }
    
    public Client() {}
    public Client(string name, string email, string password, List<Book> books)
    {
        _name = name;
        _email = email;
        _password = password;
        _books = books;
    }
}