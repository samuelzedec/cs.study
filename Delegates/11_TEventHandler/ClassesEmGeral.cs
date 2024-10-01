namespace _11_TEventHandler;

public class Pedido
{
    private event EventHandler<PedidoEventArgs>? CriarPedido;

    public void ChamarPedido(string name, long number, string email, string message = "Mensagem não informada!")
    {
        Console.WriteLine("Criando o pedido:");
        if (CriarPedido is not null)
            CriarPedido.Invoke(this, new PedidoEventArgs
            {
                Name = name,
                Email = email,
                Number = number,
                Message = message
            });
    }
    
    public void AdicionarAssinante(EventHandler<PedidoEventArgs> handler) // Método para adicionar assinantes
        => CriarPedido += handler;
}

public static class Email
{
    public static void Enviar(object? sender, PedidoEventArgs e)
        => Console.WriteLine($"\nEnviando um e-mail! \nNome: {e.Name} \nE-mail: {e.Email} \nMensagem: {e.Message}");
}

public static class Sms
{
    public static void Enviar(object? sender, PedidoEventArgs e)
        => Console.WriteLine($"\nEnviando um SMS! \nNome: {e.Name} \nTelefone: {e.Number} \nMensagem: {e.Message}");
}

public class PedidoEventArgs : EventArgs
{
    public required string Name { get; init; }
    public required long Number { get; init; }
    public required string Email { get; init; }
    
    public required string Message { get; init; }
    /*
     * required: Serve para garantir que a propriedade com esse modificador tenha um valor na inicialização,
     * seja pelo construtor ou pela inicialização do objeto. Se a propriedade for marcada com init, 
     * seu valor será imutável após a inicialização. Se for marcada com set, seu valor poderá ser alterado
     * posteriormente tanto fora ou internamente na classe. Caso esteja com private set,
     * só irá ser modificado dentro da instâcia.
     *
     *
     * readonly: Serve para garantir que o valor de uma propriedade seja imutável após sua inicialização 
     * usando o construtor. Não é permitido usar o modificador set em uma propriedade readonly. 
     * Seu valor é imutável tanto dentro quanto fora da instância após a inicialização.
     */
    
}