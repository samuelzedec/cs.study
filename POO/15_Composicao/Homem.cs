namespace _15_Composicao;
internal class Homem : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar;

    public Homem()
    {
        _comportamentoAndar = new();
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Homem));
        _comportamentoAndar.Andar();
    }
}
