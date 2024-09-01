namespace _16_Agregacao;
internal class Professor
{
    public string? Nome { get; set; }
    public string? Disciplina { get; set; }

    public Professor(string? nome, string? disciplina)
    {
        Nome = nome;
        Disciplina = disciplina;
    }
}
