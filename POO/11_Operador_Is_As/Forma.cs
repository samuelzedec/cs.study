namespace _11_Operador_Is_As;
internal class Forma
{
    protected int xpos, ypos;

    public Forma() { }

    public Forma(int xpos, int ypos)
    {
        this.xpos = xpos;
        this.ypos = ypos;
    }

    public virtual void Desenhar()
        => Console.WriteLine($"Desenhar - Forma na posição: ({xpos}, {ypos})");
}

