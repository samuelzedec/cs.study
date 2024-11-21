using _04.Conjuntos;
Console.WriteLine("Conjuntos I");

/*
//Método .Distinct() e .DistinctBy() - Remove duplicatas
/*
 * .Distinct() = faz a diferenciação de forma simples
 * .DistinctBy() = faz a diferenciação onde pode ser definido o critério, usando uma expressão lambda
 #1#

/*
 * O método .Distinct() é sensitive case
 * Mas podemos ignorar isso usando um método da classe StringComparer
 * Sendo ele: .OrdinalIgnoreCase
 #1#

var nomes = FonteDados.GetNomes();
var idades = FonteDados.GetIdades().Distinct();
var alunos = FonteDados.GetAlunos().ToList();
var alunosIdadeDistintas = alunos.DistinctBy( a => a.Idade ).ToList();

foreach (var aluno in alunosIdadeDistintas)
{
    Console.WriteLine($"Aluno: {aluno.Nome} Idade: {aluno.Idade}");
}

var nomesUnicos = nomes.Distinct(StringComparer.OrdinalIgnoreCase);
foreach (var nome in nomesUnicos)
{
    Console.WriteLine(nome);
}

foreach (var idade in idades)
{
    Console.WriteLine(idade);
}*/

//Método .Except() e .ExceptBy() - Usado para retornar os elementos que estão na primeira fonte de dados, mas não na segunda fonte de dados
var fonte1 = FonteDados.GetPaises1();
var fonte2 = FonteDados.GetPaises2();

//Aqui estamos verificando se na fonte1 há elementos da fonte2, os que não tiverem na fonte2, será retornado
var result = fonte1.Except(fonte2, StringComparer.InvariantCultureIgnoreCase);
// var result = fonte1.Except(fonte2);
foreach (var r in result)
{
    Console.WriteLine(r);
}

var fonteAluno = FonteDados.GetAlunos();
var alunosReprovados = new List<string>() { "Amanda", "Alicia", "Jaime" };
var alunosAprovados = fonteAluno.ExceptBy(alunosReprovados, n => n.Nome);

foreach (var aluno in alunosAprovados)
{
    Console.WriteLine($"Aprovado: {aluno.Nome} ");
}


