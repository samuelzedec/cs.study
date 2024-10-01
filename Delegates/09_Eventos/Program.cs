internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("## Eventos ##\n");
        Pedido pedido = new();

        Console.WriteLine("Usando o evento OnCriarPedido");
        
        //Lembrando que ao passar um método para um evento, não precisa dos "()"
        pedido.OnCriarPedido += Email.Enviar;
        pedido.OnCriarPedido += SMS.Enviar;
        
        //Chamando o evento
        pedido.CriarPedido();
        
        
        Console.ReadKey();
    }
}

public delegate void PedidoEventHandler();
public class Pedido
{
    // Aqui estamos declarando um evento que deve ser do tipo delegado PedidoEventHandler
    public event PedidoEventHandler? OnCriarPedido; 
    
    public void CriarPedido()
    {
        Console.WriteLine("Pedido Criado !!! ");
        
        // Verificamos se o evento OnCriarPedido tem algum método inscrito, se tiver, ele é invocado.
        if (OnCriarPedido is not null) OnCriarPedido();
    }
    
    /*
     * Ao chamar o método CriarPedido, ele irá verificar se OnCriarPedido não é nulo.
     * Caso não seja nulo, os métodos associados ao evento (se houverem) serão executados.
     */
}

public class Email
{
    public static void Enviar() => Console.WriteLine("Enviando um email !!! ");
}

public class SMS
{
    public static void Enviar() => Console.WriteLine("Enviando um SMS !!! ");
}
