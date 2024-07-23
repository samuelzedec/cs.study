internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Argumentos Nomeados ##\n");
        Email email = new();

        Console.WriteLine("------------------------\n");

        email.Exibir(titulo: "Urgente", assunto: "Fazer o mercado hoje, porque estamos sem comida...", destino: "samuelzedec@gmail.com");

        Console.WriteLine("\n------------------------");

    }
}

public class Email() 
{
    public void Exibir(string destino, string titulo, string assunto) {
        Console.WriteLine($"Destino: {destino} \nTitulo: {titulo} \nAssunto: {assunto}");
    }
}