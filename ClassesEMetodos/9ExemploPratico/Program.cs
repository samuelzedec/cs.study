internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Exemplo Prático ##\n");
        Cadastro cadastro = new();

        var cliente = cadastro.Registar();
        cadastro.ExibirDados(cliente);

        //Alterando Renda
        cadastro.Registar(cliente);
        cadastro.ExibirDados("Olá, Mundo!", cliente);

        Console.ReadKey();
    }
}

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string Nome, int Idade, decimal Renda) {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Renda = Renda;
    }

    public Cliente()
    {}
}
public class Cadastro
{
    public Cliente Registar() {
        Cliente cliente = new("Maria", 23, 3000);
        return cliente;
    }

    public Cliente Registar(Cliente cliente) {
        cliente.Renda = 3500.00m;
        return cliente;
    }

    public void ExibirDados(Cliente cliente) {
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
    }

    public void ExibirDados(string texto, Cliente cliente) {
        Console.Write($"\n{texto}\t");
        Console.WriteLine($"{cliente.Nome} {cliente.Renda.ToString("c")}");
    }
}