using _25PartialClass;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Partial Class ##\n");
        MinhaPartialClass minhaPartial = new();

        Console.WriteLine("Idade para nascidos em: 07/08/2003\n");
        var idade = minhaPartial.CalculeIdade(new DateTime(2003, 8, 7));

        Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

        Console.WriteLine("\nIdade para nascidos em: 20/01/2005");
        var data1 = DateTime.Now;
        var data2 = new DateTime(2005, 01, 02);

        var diferenca = minhaPartial.DiferencaEntreDatas(data1, data2);
        Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)}");
    }
}