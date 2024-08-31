namespace _12_Modificadro_Abstract;
internal class Quadrado : Forma
{
    public double Lado { get; set; }

    public override void CalcularArea()
    {
        Area = Math.Pow(Lado, 2);
    }

    public override void CalcularPerimetro()
    {
        Perimetro = 4 * Lado;
    }
}
