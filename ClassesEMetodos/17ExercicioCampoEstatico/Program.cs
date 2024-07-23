internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Exercício Campo Estático ##\n");
        ContaCorrente.Juros = 4.25f;

        ContaCorrente c1 = new() {
            Conta = 101,
            Nome = "Maria",
            //Juros = 3.99f
        };

        ContaCorrente c2 = new() {
            Conta = 102,
            Nome = "Marta",
            //Juros = 4.99f
        };

        Console.WriteLine($"Cliente: {c1.Nome} \n\tJuros Anual: {c1.JurosAnual()} \n\tConta: c1: {c1.Conta}");
        Console.WriteLine("\n------------------------------\n");
        Console.WriteLine($"Cliente: {c2.Nome} \n\tJuros Anual: {c1.JurosAnual()} \n\tConta: {c2.Conta}");
    }
}

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual() {
        return Juros * 12;
    }
}