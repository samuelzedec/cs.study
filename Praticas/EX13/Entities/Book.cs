namespace Entities.Menu;

public class Book
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    
    private string _gender;
    public string Gender
    {
        get => _gender;
        set => _gender = value;
    }

    private DateTime _releaseDate;
    public DateTime ReleaseDate
    {
        get => _releaseDate;
        set => _releaseDate = value;
    }

    private decimal _price;
    public decimal Price
    {
        get => _price;
        set => _price = value;
    }

    private Author _author;
    public Author Author
    {
        get => _author;
        set => _author = value;
    }
    public Book(){}
    public Book(string name, string gender, DateTime releaseDate, decimal price, Author author)
    {
        _name = name;
        _gender = gender;
        _releaseDate = releaseDate;
        _price = price;
        _author = author;
    }
}