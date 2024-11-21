Console.WriteLine("## Operadores de Ordenação ##\n");
/*//Método .OrderBy() é usado para classificar os dados em ordem crescente (ascendente) sem alterar os dados mas apenas sua ordem.
//Caso a ordem tenha que ser descendente basta usar o operador .OrderbyDescending()
List<string> nomes = new List<string>()
{
    "Paulo", "Tarcisio", "Amaral", "Pedro", "Debora", "Helena", "Percival", "Manoel", "Rute", "José"
};

var listaAscendente = nomes.OrderBy(n => n);
var listaDescendente = nomes.OrderByDescending(n => n);
Console.WriteLine($"Nomes ordenados de formar ascendente: {string.Join(", ", listaAscendente)}");
Console.WriteLine($"Nomes ordenados de formar descendente: {string.Join(", ", listaDescendente)}");

//Caso queiramos classifar por duas propriedades em tipos complexos podemos usar o .ThenBy() e .ThenByDescending()
List<Aluno> alunos = new List<Aluno>()
{
    new Aluno() { Nome = "Maria", Idade = 20 },
    new Aluno() { Nome = "Manoel", Idade = 22 },
    new Aluno() { Nome = "Miriam", Idade = 21 },
    new Aluno() { Nome = "Matilda", Idade = 21 },
};

var listaAlunos = alunos.OrderBy(n => n.Idade)
    .ThenBy(n => n.Nome);
foreach (var aluno in listaAlunos)
{
    Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}");
}*/

//O método .Reverse() retorna uma nova lista com os itens na sequência reversa
var aluno = new Aluno() { Nome = "Samuel", Idade = 19, DataNascimento = new DateTime(2005, 01, 20)};
var numeros = new List<int>() { 10, 30, 50, 40, 60, 20, 70, 100 };
/*
 * Para usar o Método .Reverse() em uma lista, primeiro temos q transforma-lá em uma IEnumerable<T> ou IQueryable<T
 * Para isso usamos os métdos .AsEnumerable() e .AsQueryable()
 */
var numReverse = numeros.AsEnumerable().Reverse();
Console.WriteLine($"Numeros em ordem reversa: {string.Join(" - ", numReverse)}");


public class Aluno  
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public DateTime DataNascimento { get; set; }
}