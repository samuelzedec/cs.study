namespace _03.OperadoresDeProjecao;

public class FonteDados
{
    public static List<Aluno> GetAlunos() 
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Maria", Idade = 22, Nota = 7, Cursos = new List<string> { "C#", "JavaScript", "Ruby" } },
            new Aluno() { Nome = "Manoel", Idade = 24, Nota = 6, Cursos = new List<string> { "Python", "Java", "Go" } },
            new Aluno() { Nome = "Amanda", Idade = 21, Nota = 5, Cursos = new List<string> { "Swift", "PHP", "Kotlin" } },
            new Aluno() { Nome = "Carlos", Idade = 18, Nota = 9, Cursos = new List<string> { "TypeScript", "Rust", "Dart" } },
            new Aluno() { Nome = "Alicia", Idade = 17, Nota = 4, Cursos = new List<string> { "C++", "Scala", "Perl" } },

        };
        return alunos;
    }

    public static List<Funcionario> GetFuncionarios() 
    {
        List<Funcionario> funcionarios = new()
        {
            new Funcionario() { Nome = "Maria", Idade = 22, Salario = 3290.55m },
            new Funcionario() { Nome = "Manoel", Idade = 24, Salario = 4125.45m },
            new Funcionario() { Nome = "Amanda", Idade = 21, Salario = 5123.99m },
            new Funcionario() { Nome = "Carlos", Idade = 18, Salario = 6200.50m },
            new Funcionario() { Nome = "Alicia", Idade = 17, Salario = 4099.11m },
        };
        return funcionarios;
    }
}
