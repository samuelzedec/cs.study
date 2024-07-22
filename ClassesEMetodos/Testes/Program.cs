Console.WriteLine("## Meus Testes em c# ##\n");
var testes = new Testes();

double quebrado = testes.incrementar(out int valor);
Console.WriteLine($"{valor} | {quebrado}");

public class Testes {
    public double incrementar(out int pixel) {
        pixel = 1 + 1;
        return 3.5;
    }
}