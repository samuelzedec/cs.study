Console.WriteLine("## Herença - Modificiador Sealed ##\n");

Cliente cli = new() { Nome = "José" };


Console.ReadKey();

sealed public class Pessoa
{
    public string? Nome { get; set; }

    public void ExibirNome() 
        => Console.WriteLine($"\nMeu nome é {this.Nome}");
}

public class Cliente 
{
    public string? Nome { get; set; }
    public void ExibirNome()
        => Console.WriteLine($"\nMeu nome é {this.Nome}");
}
