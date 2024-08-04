internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Tipos Anônimos ##\n");

        //var aluno = new
        //{
        //    Nome = "Maria",
        //    Idade = 42
        //};
        //Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}");

        //var aluno = new
        //{
        //    Id = 1,
        //    Nome = "Jairo",
        //    Email = "jario@email.com",
        //    Endereco = new {Id = 1, Cidade = "Santos", Pais = "Brasil"}
        //};

        //Console.WriteLine($"Endereco Cidade: {aluno.Endereco.Cidade}");


        var alunos = new[]
        {
            new { id = 1, Nome = "Maria", Email = "maria@email.com" },
            new { id = 2, Nome = "Sonia", Email = "sonia@email.com" },
            new { id = 3, Nome = "Bruno", Email = "bruno@email.com" }
        };

        Console.WriteLine(alunos[0].Nome);
        Console.WriteLine(alunos[0].Email);
        Console.WriteLine(alunos[0].id);
    }
}