Console.WriteLine("## Construtor ##\n");
Aluno aluno = new("", Convert.ToInt32("4"), "Feminino", "S");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado  == null ? "null" : aluno.Aprovado);

//Construtor padrão
public class Aluno
{
    public Aluno(string nome, int idade, string sexo, string aprovado) {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    } 
    public string? Nome; //string = null;
    public int Idade; //int = 0;
    public string? Sexo;
    public string? Aprovado;
}
