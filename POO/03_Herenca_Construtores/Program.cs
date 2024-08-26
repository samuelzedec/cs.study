Console.WriteLine("## Herença - Construtores ##\n");
Aluno aluno = new("José", 19);

public class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da class Pessoa com parametro");
    }

    public Pessoa(int idade)
    {
        Console.WriteLine("Construtor com int");
    }
}

public class Aluno : Pessoa
{
    public Aluno()
    {
        Console.WriteLine("construtor da classe Aluno");
    }

    public Aluno(string nome, int idade) : base(idade)
    {
        Console.WriteLine("construtor da classe Aluno com parametro" + nome);
    }
}