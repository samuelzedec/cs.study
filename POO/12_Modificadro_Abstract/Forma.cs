namespace _12_Modificadro_Abstract;
internal abstract class Forma
{
    public string? Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    //Métodos abstratos
    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    //Método comum
    public string Descricao()
        => "Sou a classe abstrata Forma";
}
