Console.WriteLine("## Herença: Virtual e Override ##\n");

Gato gato = new Gato() { Nome = "Gizmo" };
gato.ExibirNome();

Cachorro cao = new() { Nome = "Prado" };
cao.ExibirNome();

Console.ReadKey();

public class Animal
{
    public string? Nome { get; set; }

    public virtual void ExibirNome() 
    {
        Console.WriteLine($"\nMeu nome é {this.Nome}");
    }
}

public class Gato : Animal
{
    public override void ExibirNome()
    {
        Console.WriteLine($"\nEu sou um gato. Meu nome é: {this.Nome}");
    }
}

public class Cachorro : Animal
{
    public override void ExibirNome()
    {
        Console.WriteLine($"\nEu sou um cachorro    . Meu nome é: {this.Nome}");
    }
}
