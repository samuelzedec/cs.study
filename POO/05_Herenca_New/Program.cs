Console.WriteLine("## Herença - Operador New ##\n");

Aluno aluno = new() { Nome = "Maria", Curso = "Engenharia de Software" };
Console.WriteLine(aluno.Saudacao() );

Console.ReadKey();

public class Pessoa
{
    public string? Nome { get; set; }

    public string Saudacao()
        => $"Oi, Eu sou o(a) {Nome}";
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }

    public new string Saudacao()
        => $"Oi, eu sou o(a) {Nome} do curso de: {Curso}";
}