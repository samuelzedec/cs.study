namespace _16_Agregacao;

internal class Departamento
{
    public string? Nome { get; set; }
    private List<Professor> Professores { get; set; }

    public Departamento(string? nome)
    {
        this.Nome = nome;
        Professores = new List<Professor>();
    }

    public void IncluirProfessor(Professor professor)
    {
        Professores?.Add(professor);
    }

    public void ExibirProfessor()
    {
        Console.WriteLine($"Departamento de: {Nome}\n");
        foreach(var professor in Professores)
        {
            Console.WriteLine($"{professor.Nome} -> {professor.Disciplina}");
        }
    }
}
