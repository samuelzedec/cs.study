class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Execício ##\n");

        // Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
        // Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);
        // chevrolet.Exibir();
        // chevrolet.Acelerar("Sedan");
        // ford.Exibir();

        int potencia = 500;
        Carro lamborghini = new("Uracan", "Ford", "Lamborghini", 2022, potencia);

        lamborghini.Exibir(modelo: lamborghini.Modelo, marca: lamborghini.Marca, montadora: lamborghini.Montadora, potencia: lamborghini.Potencia);

        lamborghini.Exibir(modelo: lamborghini.Modelo, marca: lamborghini.Marca, montadora: lamborghini.Montadora, potencia: lamborghini.Potencia, ano: lamborghini.Ano);

        Carro.ObterValorIPVA();
        Console.WriteLine($"IPVA: {Carro.ValorIpva}");

    }
}

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;
    public static double ValorIpva;

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

    public void Dados() {
        Console.WriteLine($"Modelo: {this.Modelo}");
        Console.WriteLine($"Montadora: {this.Montadora}");
    }

    public void Exibir() {
        Dados(this);
    }

    public int AumentarPotencia(int potencia) {
        return potencia + 3;
    }

    public void AumentarPotencia(ref int potencia) {
        potencia += 5;
    }

    public void AumentarPotenciaVelocidade(ref int potencia, out double velocidade) {
        velocidade = potencia * 1.75;
        potencia += 3;
    }

    public void Exibir(string modelo, string montadora, string marca, int potencia, int ano = 2000) {
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Montadora: {montadora}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Potencia: {potencia}");
        Console.WriteLine($"Ano: {ano}\n");
    }

    public static void ObterValorIPVA() {
        ValorIpva = 4;
    }

}