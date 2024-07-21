Console.WriteLine("## Passando Parâmetros ##\n");
Aluno gabriel = new();

gabriel.Consultar();

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
    public void Resultado(Aluno gabriel) {
        Console.WriteLine($"\nO aluno {gabriel.Nome}, sexo {gabriel.Sexo}, com {gabriel.Idade} anos");

        if(gabriel.Aprovado == "S" ) {
            Console.WriteLine("Foi aprovado");
        } else {
            Console.WriteLine("Foi reprovado");
        }
    }
}