using System.Runtime.CompilerServices;

namespace EX9;

public class Cliente : EventArgs
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Telefone { get; set; }
    public required DateTime DataAtual { get; set; }
    public required string Mensagem { get; set; }
}

public class Contato
{
    private event EventHandler<Cliente>? AcionarCliente;

    public void Adicionar(EventHandler<Cliente> eventos)
        => AcionarCliente += eventos;

    public void ContatarCliente(string name, string email, string telefone, DateTime data, string mensagem = "Retorne o mais rápdio possível! \n\tObrigado pela atenção")
    {
        if (AcionarCliente is null) return;
        
        AcionarCliente.Invoke(this, new Cliente
        {
            Name = name,
            Email = email,
            Telefone = telefone,
            DataAtual = data,
            Mensagem = mensagem
        });
    }
}