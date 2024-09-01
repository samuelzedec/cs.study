namespace _15_Composicao;
internal class Sardinha : Animal
{
    private readonly ComportamentoNadar _comportamentoNadar;

    public Sardinha()
    {
        _comportamentoNadar = new();
    }

    public void Locomocao()
        => _comportamentoNadar.Nadar();
}
