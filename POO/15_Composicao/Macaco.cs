namespace _15_Composicao;
internal class Macaco : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar;

    public Macaco()
    {
        _comportamentoAndar = new();
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Macaco));
        _comportamentoAndar.Andar();
    }
}
