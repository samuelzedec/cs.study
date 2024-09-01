namespace Interface;

internal interface ISalvar
{
    public void Salvar();
    public void Compactar()
        => Console.WriteLine("Compactando arquivo...");
}
