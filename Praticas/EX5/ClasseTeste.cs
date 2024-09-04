namespace EX5;
public class ClasseTeste
{
    private readonly string Name;

    public ClasseTeste(string Name) {
        this.Name = Name;
    }

    public void Retornar() 
        => Console.WriteLine($"Seu nome é: {Name}");
}
