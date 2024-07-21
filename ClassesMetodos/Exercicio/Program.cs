class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Execício ##\n");

        Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
        Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

        chevrolet.Acelerar("Sedan");

        chevrolet.Exibir();
        ford.Exibir();
    }
}

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string Modelo, string Montadora, string Marca, int Ano, int Potencia) {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public Carro(string modelo, string montadora) {
        Modelo = modelo;
        Montadora = montadora;
    }

    public double Velocidade(int potencia) {
        return Convert.ToDouble(potencia * 1.75);
    }

    public void Acelerar(string Marca) {
        Console.WriteLine($"Acelerando o meu {Marca}\n");
    }

    private void Dados(Carro car) {
        Console.WriteLine($"Modelo: {car.Modelo}");
        Console.WriteLine($"Montadora: {car.Montadora}");
        Console.WriteLine($"Marca: {car.Marca}");
        Console.WriteLine($"Ano: {car.Ano}");
        Console.WriteLine($"Potencia: {car.Potencia}\n");
    }

    public void Exibir() {
        Dados(this);
    }
    }