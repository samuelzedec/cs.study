internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Argumentos Nomeados ##\n");
        Email email = new();

        Console.Write("Informe o destino: ");
        var destino = Console.ReadLine();

        Console.Write("Informe o título: ");
        var titulo = Console.ReadLine();
        
        Console.Write("Informe o assunto: ");
        var assunto = Console.ReadLine();
        

        Console.WriteLine("------------------------\n");
        email.Exibir(destino: destino);
        Console.WriteLine("\n------------------------");

    }
}

public class Email() {
    public void Exibir(string destino, string titulo = "Reunião", string assunto = "Avaliação") {
        Console.WriteLine($"Destino: {destino} \nTitulo: {titulo} \nAssunto: {assunto}");
    }
}