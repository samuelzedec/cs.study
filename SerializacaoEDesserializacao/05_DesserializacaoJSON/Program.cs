using System.Text.Json;
using _05_DesserializacaoJSON;

Console.WriteLine("## Desserialização JSON ##");
string caminho = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\SerializacaoEDesserializacao\04_SerializacaoJSON\AlunoSerializado.json";

//Lê todo o conteúdo do arquivo json e retorna em uma string completa
string jsonContent = File.ReadAllText(caminho);
Console.WriteLine(jsonContent);

//Desseriliza o objeto do arquivo JSON e retorna
var aluno = JsonSerializer.Deserialize<Aluno>(jsonContent);
Console.WriteLine($"Aluno JSON desserializado: \n\tID: {aluno.Id} \n\tNome: {aluno.Name} \n\tEmail: {aluno.Email} \n\tIdade: {aluno.Age}");
Console.WriteLine();
