namespace _25PartialClass;

public partial class MinhaPartialClass
{
    public TimeSpan CalculeIdade(DateTime DataNascimento)
    {
        return (DateTime.Now.Date - DataNascimento);
    }

    public TimeSpan DiferencaEntreDatas(DateTime data1, DateTime data2)
    {
        var diferenca = data1.Subtract(data2);
        return diferenca;
    }
}

