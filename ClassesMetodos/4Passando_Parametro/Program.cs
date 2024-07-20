Console.WriteLine("## Passando Parâmetros ##\n");
Aluno alunos = new();

alunos.Consultar();

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar() {
        Aluno aluno = new();
        Curso curso = new();

        Console.Write("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sexo: ");
        aluno.Sexo = Console.ReadLine();

        Console.Write("Aprovado (S)im / (N)ão: ");
        aluno.Aprovado = Console.ReadLine();

        //curso.Resultado(aluno.Nome, aluno.Idade, aluno.Sexo, aluno.Aprovado);
        curso.Resultado(aluno);
    }
}

public class Curso
{
    public void Resultado(Aluno aluno) {
        Console.WriteLine($"\nO aluno {aluno.Nome}, sexo {aluno.Sexo}, com {aluno.Idade} anos");

        if(aluno.Aprovado == "S" ) {
            Console.WriteLine("Foi aprovado");
        } else {
            Console.WriteLine("Foi reprovado");
        }
    }
}