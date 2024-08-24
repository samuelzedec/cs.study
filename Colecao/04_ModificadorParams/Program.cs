Console.WriteLine("## Modificador Params ##\n");
int[] valores = { 1, 2, 3, 4, 5 };

var valorTotal = Calcular.Soma(valores);

Console.WriteLine(valorTotal);

Console.WriteLine(Calcular.Soma(new int[] { 1, 2, 3, 4}));

Console.WriteLine(Calcular.Soma(1, 2, 3, 4, 5, 6));

Console.ReadKey();

public class Calcular
{
    //public static int Soma(int n1, int n2)
    //{
    //    return n1 + n2;
    //}

    //public static int Soma(int n1, int n2, int n3)
    //{
    //    return n1 + n2 + n3;
    //}

    //public static int Soma(int n1, int n2, int n3, int n4)
    //{
    //    return n1 + n2 + n3 + n4;
    //}

    public static int Soma(params int[] num)
    {
        int total = 0;
        foreach(int n in num)
        {
            total += n;
        }
        return total;
    }
}
