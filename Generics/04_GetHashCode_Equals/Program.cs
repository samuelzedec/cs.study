Console.WriteLine("## GetHashCoce e Equals ##\n");

string a = "José";
string b = "José";

int x = 100;
int y = 90;

//Console.WriteLine(a.Equals(b));
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());

//Console.WriteLine(x.Equals(y));
Console.WriteLine(x.GetHashCode());
Console.WriteLine(y.GetHashCode());


Pessoa p1 = new(1, "Ana");
Pessoa p2 = new(1, "Ana");

//Console.WriteLine(p1.Equals(p2));
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p2.GetHashCode());
Console.ReadKey();


public class Pessoa
{
    public Pessoa(int Id, string Name) 
    {
        this.Id = Id;
        this.Name = Name;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
}