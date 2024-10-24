using Entities.Money;
namespace Entities.Menu;

public class Library
{
    private readonly string _name = "LibraTech";
    public string Name => _name;

    private readonly string _email = "libratech@yahoo.com";
    public string Email => _email;

    private readonly int _password = 40028922;
    public int Password => _password;

    private Invoicing _invoicing = new();
    public Invoicing TotalRevenue
    {
        get => _invoicing;
        set => _invoicing = value;
    }

    private List<Client> _clients = new();
    public List<Client> Clients
    {
        get => _clients;
        set => _clients = value;
    }

    private List<Book> _books = new();
    public List<Book> Books
    {
        get => _books;
        set => _books = value;
    }
}