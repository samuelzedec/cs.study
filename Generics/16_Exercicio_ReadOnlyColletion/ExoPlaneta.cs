using System.Collections.ObjectModel;
namespace _16_Exercicio_ReadOnlyColletion;

public class GerenciaExoPlanetas
{
    private List<ExoPlaneta> exoPlanetas = ExoPlaneta.GetExoPlanetas();
    public ReadOnlyCollection<ExoPlaneta> ExoPlanetas
    {
        get { return exoPlanetas.AsReadOnly(); }
    }
    
    public void AdicionaPlaneta(ExoPlaneta planeta)
    {
        exoPlanetas.Add(planeta);
    }    
}

public class ExoPlaneta
{
    public ExoPlaneta(string Nome)
    {
        this.Nome = Nome;
    }
    
    public readonly string Nome;
    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
            new("Procima Centauri b"),
            new("Kleper 186-f"),
            new("Gliesi 1061-c")
        };
    }
}