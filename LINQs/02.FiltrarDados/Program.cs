using _02.FiltrarDados;
Console.Clear();
Console.WriteLine("## LINQ - Filtar Dados ##");

var numbers = FonteDados.GetNumeros();
var listaNegra = FonteDados.GetListaNegra();
var alunos = FonteDados.GetAlunos();

// O método Where() é utilizado para filtrar os dados de acordo com uma condição
var result1 = numbers.Where(n => n < 10);
Console.WriteLine(string.Join("-", result1));

var result2 = numbers.Where(n => n > 1 && n != 4 && n < 20);
Console.WriteLine(string.Join("-", result2));

var result3 = numbers.Where(n => !listaNegra.Contains(n));
Console.WriteLine(string.Join("-", result3));

var result4 = numbers
    .Where(n => n > 1)
    .Where(n => n != 4)
    .Where(n => n < 20);
Console.WriteLine(string.Join("-", result4));

//O método .StartsWith() é utilizado para verificar se uma string começa com um determinado valor
//O método .EndsWith() é utilizado para verificar se uma string termina com um determinado valor
var result5 = alunos
    .Where(a => a.Nome.StartsWith('A'))
    .Where(i => i.Idade < 18);

foreach(var aluno in result5)
    Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");

