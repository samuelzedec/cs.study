using System.Globalization;
using _05.ConjuntosII;

Console.WriteLine("## Operadores de conjunto ##\n");
/*//.Intersect() e .IntersectBy() são métodos para ver o que há de em comum em ambas as fontes de dados
var fonte1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
var fonte2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

var fonte3 = fonte1.Intersect(fonte2);
Console.WriteLine($"valores que existem em ambas as fontes de dados: {string.Join(", ", fonte3)}");

//Usando a sobre carga 
var fonte4 = new List<string>() { "Brasil", "USA", "UK", "Argentina", "China" };
var fonte5 = new List<string>() { "Brasil", "uk", "Argentina", "França", "Japão" };

var fonte6 = fonte4.Intersect(fonte5, StringComparer.OrdinalIgnoreCase);
Console.WriteLine($"Valores que existem em ambas as fontes de dados (ignorando o sensitive case): {string.Join(", ", fonte6)}");

//Usando com tipos complexos
var turmaA = FonteDados.GetTurmaA();
var turmaB = FonteDados.GetTurmaB();
var consulta2 = turmaA.Select( p => p.Nascimento.Year)
    .Intersect( turmaB.Select(p => p.Nascimento.Year));


var alunosTurmaComNomesIguais = turmaA.IntersectBy(turmaB.Select(p => p.Nascimento.Year),
    p => p.Nascimento.Year);
Console.WriteLine("Alunos com o mesmo nomes iguais:");
foreach (var aluno in alunosTurmaComNomesIguais)
{
    Console.WriteLine(aluno.Nome);
}*/

//.Union() e UnionBy são métodos para unir as diferenças, sendo assim o ele irá juntar sem repetir elementos caso cada um já tenha o mesmo
var font1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
var font2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
var result = font1.Union(font2);
Console.WriteLine($"Resultado dos conjuntos unidos: {string.Join(", ", result)}");

var fonte4 = new List<string>() { "Brasil", "USA", "UK", "Argentina", "China" };
var fonte5 = new List<string>() { "Brasil", "uk", "Argentina", "França", "Japão" };
var result2 = fonte4.Union(fonte5, StringComparer.OrdinalIgnoreCase);
Console.WriteLine($"Resultado dos conjuntos: {string.Join(", ", result2)}");

var turmaA = FonteDados.GetTurmaA();
var turmaB = FonteDados.GetTurmaB();
var result3 = turmaA.UnionBy(turmaB, a => a.Nome);

Console.WriteLine("Nomes diferentes das duas turmas");
foreach (var aluno in result3)
{
    Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Data de nascimento: {aluno.Nascimento.ToString(CultureInfo.InvariantCulture)}");
}