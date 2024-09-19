using System.Runtime.Serialization;

namespace Personalizadas;

public class SaldoInsuficienteException : Exception
{
    //Os 3 construtores padrões 
    public SaldoInsuficienteException()
    {}

    public SaldoInsuficienteException(SerializationInfo info, StreamingContext context) : base(info, context)
    {}

    public SaldoInsuficienteException(string? message) : base(message)
    {}

    //Construtor criado
    public SaldoInsuficienteException(decimal saque, decimal saldo) : base($"\nException: Valor do saque {saque} é superior ao saldo {saldo}")
    {}

    //Reescrevendo o Método Message
    public override string Message
    {
        get
        {
            return "Não existe saldo insuficiente para o valor do saque";
        }
    }

    //Rescrevendo o método HelpLink
    public override string? HelpLink
    {
        get { return "info: https://rb.gy/clgqbv"; }
    }
}