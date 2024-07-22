internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Argumentos por referência - out");

        Console.Write("Informe o raio do circulo: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        Circulo circulo = new();
        double circunferencia = circulo.CarcularAreaPerimetro(raio, out double areaFinal);
        
        Console.WriteLine($"Perímetro da Circuferencia {circunferencia}");
        Console.WriteLine($"Área da Circuferencia {areaFinal}");
    }
}

public class Circulo
{
    public double CarcularAreaPerimetro(double raio, out double area) {
        area = Math.PI * Math.Pow(raio, 2);
        return 2 * Math.PI * Math.Pow(raio, 2);
    }
}