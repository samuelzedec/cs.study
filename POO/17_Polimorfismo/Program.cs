Console.WriteLine("## Polimorfismo ##");

List<Figura> lista = new()
{
    new Circulo(),
    new Tringulo(),
};

foreach(var i in lista)
{
    i.Desenhar();
}

Console.ReadKey();

public class Figura 
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Executando Desenhar na classe base");
    }
}


public class Circulo : Figura 
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando Ciruclo");
    }
}

public class Tringulo : Figura 
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um triangulo");
        base.Desenhar();
    }
}

