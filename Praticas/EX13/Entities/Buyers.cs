using System.Security.Cryptography;

namespace Entities;

public class Buyers
{
    public string Name;
    public string Email;
    public List<Book> Books;

    public Buyers(string name, string email,List<Book> books)
    {
        Name = name;
        Email = email;
        Books = books;
    }
    
}