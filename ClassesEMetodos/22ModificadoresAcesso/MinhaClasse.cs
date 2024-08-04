namespace _22ModificadoresAcesso;

public class MinhaClasse
{
    public static void teste()
    {
        Console.WriteLine("Olá Mundo");
        MinhaStruct.teste();
    }
}

internal struct MinhaStruct
{
    internal static void teste()
    {
        Console.WriteLine("Olá pessoas");
    }
}


