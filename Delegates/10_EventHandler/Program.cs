internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("## EventHandler ##\n");
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

public class Pedido
{
    // Aqui estamos declarando um evento que deve ser do tipo delegado EventHandler (palavra reservada)
    public event EventHandler? OnCriarPedido; 
    
    public void CriarPedido()
    {
        Console.WriteLine("Pedido Criado !!! ");
        
        // Verificamos se o evento OnCriarPedido tem algum método inscrito, se tiver, ele é invocado.
        if (OnCriarPedido is not null) OnCriarPedido(this, EventArgs.Empty);
        /*
         * this: referência a própria classe, no caso é como se ele tivesse dizendo que a classe "Pedido" chamou o evento
         * EventArgs.Empty: quer dizer que o segundo argumento é vazio e não temos nenhuma informação extra para passar
         */
    }
    
    /*
     * Ao chamar o método CriarPedido, ele irá verificar se OnCriarPedido não é nulo.
     * Caso não seja nulo, os métodos associados ao evento (se houverem) serão executados.
     */
}

public class Email
{
    public static void Enviar(object? sender, EventArgs e) => Console.WriteLine("Enviando um email !!! ");
}

public class SMS
{
    public static void Enviar(object? sender, EventArgs e) => Console.WriteLine("Enviando um SMS !!! ");
}
