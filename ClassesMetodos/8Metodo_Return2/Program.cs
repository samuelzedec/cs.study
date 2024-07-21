using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Assinatura de método - Sobrecarga ##\n");
        Email email = new();

        email.Enviar("empresa.com.br");
        email.Enviar("empresa.com.br", "Proposta Comercial");
        email.Enviar("empresa.com.br", 199.00m);
        email.Enviar(199.00m ,"empresa.com.br");

        Console.ReadKey();
    }
}

public class Email
{
    public void Enviar(string endereco) {
        Console.WriteLine(endereco);
        Console.WriteLine("Assunto padrão");
    }
    public void Enviar(string endereco, string assunto) {
        Console.WriteLine(endereco);
        Console.WriteLine(assunto);
    }
    public void Enviar(string endereco, decimal valor) {
        Console.WriteLine(endereco);
        Console.WriteLine("Proposta comercial");
        Console.WriteLine(valor);
    }

    public void Enviar(decimal valor, string endereco) {
        Console.WriteLine(endereco);
        Console.WriteLine("Pagamento de fornecedor");
        Console.WriteLine(valor);
    }


}