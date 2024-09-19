using Personalizadas;
Console.WriteLine("## Exceções Personalizadas ##\n");

try
{
    Conta c1 = new(100, "Maria", 100m);
    Console.WriteLine(c1.ToString());
    c1.Depositar(100m);
    Console.WriteLine($"Saldo: {c1.Saldo:C}");
    c1.Sacar(300m);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.HelpLink);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}




public class Conta
{
    public Conta(int numero, string? titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depositou: {valor}");
        return valor;
    }

    public decimal Sacar(decimal valor)
    {
        Console.WriteLine($"Sacou: {valor}");
        if (Saldo < valor) throw new SaldoInsuficienteException(valor, Saldo);

        Saldo -= valor;
        return valor;
    }

    public override string ToString()
    {
        return $"Conta : {Numero} : {Titular} - Saldo: {Saldo:C}";
    }
}