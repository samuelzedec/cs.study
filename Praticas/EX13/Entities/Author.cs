namespace Entities;

public class Author
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    
    private string _briefBiography;
    public string BriefBiography
    {
        get => _briefBiography;
        set => _briefBiography = value;
    }
    
    public Author() {}
    
    public Author(string name, string briefBiography)
    {
        _name = name;
        _briefBiography = briefBiography;
    }
}