class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Constantes ##\n");

        // const int ANO = 12;
        // const int MES = 30, SEMANA = 7, QUINZENA =15;

        // const int MESES_ANO = 12;
        // const int DIAS_ANO = 365;

        // const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;
        // Console.WriteLine(DIAS_POR_MES);

        double raio, perimetro, area;
        const double PI = Math.PI;

        Console.Write("Informe o valor do raio: ");
        raio = Convert.ToDouble(Console.ReadLine());

        perimetro = 2 * PI * raio;
        area = PI * Math.Pow(raio, 2);

        Console.WriteLine($"Perimetro: {perimetro}");
        Console.WriteLine($"Area: {area}");
        Console.ReadKey();
    }
}