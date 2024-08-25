Console.WriteLine("## IEnumerable ##\n");

var limiteCredito = new List<Limite>();
for(int i = 1; i <= 15; i++)
{
    limiteCredito.Add(new Limite() { Numero = i });
}

var limiteComRestricao = limiteCredito.Where(x => x.AnaliseLimite());
var primeiroLimiteComRestricao = limiteComRestricao.FirstOrDefault();

//if(limiteComRestricao.Count() > 3)
//{
//    Console.WriteLine("\n### Temos mais de 3 limites com restrição");
//}

Console.WriteLine("\nFim do processamento...");

public class Limite
{
    public int Numero { get; set; }
    private bool isRestricao;

    public Limite()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }

    public bool AnaliseLimite()
    {
        Console.WriteLine($"Executa análise de limite de Crédito para o limite {Numero}");
        return isRestricao;
    }
}

