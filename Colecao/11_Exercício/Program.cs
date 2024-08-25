internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Execício ##\n");

        List<Aluno> alunos = new()
        {
            new Aluno("Maria", 8.75),
            new Aluno("Manoel", 6.95),
            new Aluno("Amanda", 7.25),
            new Aluno("Carlos", 6.55),
            new Aluno("Jaime", 8.50),
            new Aluno("Debora", 5.95),
            new Aluno("Alicia", 9.25),
            new Aluno("Sandra", 5.55),
            new Aluno("Marta", 7.85),
            new Aluno("Sueli", 9.15)
        };


        Aluno.Exibir(alunos);
        Console.WriteLine();

        Aluno.AddAlunos(ref alunos);
        Aluno.Exibir(alunos);
        Console.WriteLine();

        Aluno.RemoveAluno(ref alunos);
        Aluno.Exibir(alunos);
        Console.WriteLine();

        Aluno.OrdenarLista(alunos);
        Console.WriteLine();

        Aluno.MaioresNotas(alunos);
    }
}

public class Aluno
{
    public string? nome;
    public double nota;

    public Aluno(string nome, double nota)
    {
        this.nome = nome;
        this.nota = nota;
    }

    public static void Exibir(List<Aluno> list)
    {
        foreach(var aluno in list)
        {
            Console.WriteLine($"Aluno: {aluno.nome} - Nota: {aluno.nota}");
        }
    }

    public static void AddAlunos(ref List<Aluno> list)
    {
        list.Add(new Aluno("Bia", 7.75));
        list.Add(new Aluno("Mario", 8.95));
    }

    public static void RemoveAluno(ref List<Aluno> list)
    {
        var aluno = list.FindIndex(x => x.nome == "Amanda");
        list.RemoveAt(aluno);
    }
    public static void OrdenarLista(List<Aluno> list)
    {
        var listaOrdenada = list.OrderBy(x => x.nome).ToList();
        Exibir(listaOrdenada);
    }
    public static void MaioresNotas(List<Aluno> list)
    {
        var listNota = list.Where(x => x.nota >= 8.0).ToList();
        Exibir( listNota );
    }
}