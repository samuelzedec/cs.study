namespace _10_Upcasting_Downcasting;
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
