using Propriedade;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Propriedades ##\n");

        Produto p1 = new()
        {
            Nome = "Cardeno Espiral",
            Preco = 4.99,
            EstoqueMinimo = 10
        };
      
        p1.Exibir();
    }
}