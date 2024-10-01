using System.Threading.Channels;
using _11_TEventHandler;

Console.WriteLine("## EventHandler<TEventArgs> ##");
Pedido pedido = new();

pedido.AdicionarAssinante(Email.Enviar);
pedido.AdicionarAssinante(Sms.Enviar);

pedido.ChamarPedido("Samuel", 985640774, "samuelzedec@gmail.com");

Console.ReadKey();
