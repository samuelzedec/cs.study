Console.WriteLine("## Herença ## \n");
Funcionario funci = new()
{
    Nome = "José",
    Email = "josé@email.com",
    Empresa = "Google Inc.",
    Salario = 9000
};

Console.WriteLine($"Funcionário: {funci.Nome} | {funci.Email} | {funci.Empresa} | {funci.Salario}");

Aluno aluno = new()
{
    Nome = "Samuel",
    Email = "samuelzedec@gmail.com",
    Curso = "Enganharia de Software",
    Nota = 9.5d
};

Console.WriteLine($"Aluno: {aluno.Nome} | {aluno.Email} | {aluno.Curso} | {aluno.Nota}");


Console.ReadLine();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"{this.Nome} - {this.Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public double Nota { get; set; }
}
