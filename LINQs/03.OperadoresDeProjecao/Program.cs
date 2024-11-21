using _03.OperadoresDeProjecao;
Console.Clear();
Console.WriteLine("## Operadores de Projeção ##");

//.Select() é utilizado para projetar os dados de acordo com uma regra
IEnumerable<Aluno> alunos = FonteDados.GetAlunos().ToList();
IEnumerable<string> nomes = alunos.Select(a => a.Nome);

//Filtrando somente os alunos com nota maior que 5 e seus cursos
Console.WriteLine("Alunos com nota maior de 5 e seu nome e cursos:");
var cursos = alunos
    .Where(a => a.Nota > 5)
    .Select(a => new {
        Nome = a.Nome,
        Cursos = a.Cursos
    });
//Podemos tanto cirar uma projeção para tipos anônimos quanto para tipos existentes
foreach (var curso in cursos)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"\nNome: {curso.Nome} \nCursos: ");
    foreach (var c in curso.Cursos) Console.WriteLine($"\t🚀 {c}");
    Console.ResetColor();
}

Console.WriteLine("Nome de todos os alunos:");
Console.WriteLine(string.Join(", ", nomes));

var funcionarios = FonteDados.GetFuncionarios()
    .Select(f => new {
        Nome = f.Nome,
        Cargo = f.Idade,
        SalarioAnual = f.Salario * 12
    });

Console.WriteLine("\nFuncionários com seus salários anuais:");
foreach (var funcionario in funcionarios)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nNome: {funcionario.Nome} \nCargo: {funcionario.Cargo} \nSalário Anual: {funcionario.SalarioAnual}");
    Console.ResetColor();
}

//SelectMany() é utilizado para projetar dados de uma coleção de coleções
List<List<int>> listas = new()
{
    new List<int> { 1, 2, 3 },
    new List<int> {12},
    new List<int> {5, 6, 5, 7},
    new List<int> {10, 12, 12, 13}
};

IEnumerable<int> numeros = listas.SelectMany(lista => lista);
IEnumerable<int> numerosNaoRepetidos = listas.SelectMany(lista => lista).Distinct(); //Ao usar o Distinct() não teremos elementos repetidos
var cursosEmExecucao = alunos.SelectMany(a => a.Cursos);

Console.WriteLine("\nNúmeros de todas as listas:");
Console.WriteLine(string.Join(", ", numeros));

Console.WriteLine("\nNúmeros de todas as listas sem repetição:");
Console.WriteLine(string.Join(", ", numerosNaoRepetidos));

Console.WriteLine("\nCursos em execução:");
Console.WriteLine(string.Join(", ", cursosEmExecucao));