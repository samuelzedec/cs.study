namespace Personalizadas;

public class SaldoInsuficienteException : Exception
{
    //Os 2 construtores padrões 
    public SaldoInsuficienteException() {}
    
    public SaldoInsuficienteException(string? message) : base(message) {}

    //Construtor criado
    public SaldoInsuficienteException(decimal saque, decimal saldo) : base($"\nException: Valor do saque {saque} é superior ao saldo {saldo}") {}

    //Reescrevendo o Método Message
    //public override string Message => "Não existe saldo suficiente para o valor do saque";

    //Rescrevendo o método HelpLink
    public override string HelpLink => "info: https://rb.gy/clgqbv"; 
}