Console.WriteLine("## Herença - Modificadores de Acesso ##\n");

ClasseDerivada derivada = new();
derivada.VerifcaAcesso();

Console.ReadKey();

public class ClasseDerivada : ClasseBase
{
    public void VerifcaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Internal_Membro();
        Protected_Internal_Membro();
        //Private_Membro();
    }
}

public class ClasseBase
{
    public void Public_Membro()
    {
        Console.WriteLine("Classe Base - Método Public");
    }

    protected void Protected_Membro()
    {
        Console.WriteLine("Classe Base - Método Protected");
    }

    internal void Internal_Membro()
    {
        Console.WriteLine("Classe Base - Método Internal");
    }

    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("Classe Base - Método Protected Internal");
    }

    private void Private_Membro()
    {
        Console.WriteLine("Classe Base - Método Private");
    }
}