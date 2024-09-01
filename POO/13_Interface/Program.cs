Console.WriteLine("## Interfaces ##\n");
IControle d = new Demo() { Name = "Samuel" };
d.Desenhar();
d.Exibir();
var j = d as Demo;
j?.Pintar();

Console.ReadKey();

public interface IControle
{
    //public string name; Nao pode ter campos
    public string? Name { get; set; }
    public void Desenhar();
    public void Exibir()
    {
        Console.WriteLine("Teste...");
    }
}

public interface IGrafico
{
    public void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string? Name { get; set; }
    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }


}