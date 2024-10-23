namespace UserInfo;

public class User
{
    public int Id { get; init; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public User() {}

    public User(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Id = CreateId();
        Password = password;
    }
    
    private int CreateId()
    {
        var seed = Guid.NewGuid().GetHashCode();
        var id = new Random(seed).Next(1000, 10000);
        return id;
    }
}