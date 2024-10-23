using System.Text.Json;
using System.Xml.Serialization;
using _06_Exercicio;
Console.WriteLine("## Exercício ##");

string pathJson = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\SerializacaoEDesserializacao\06_Exercicio\file.json";
string pathXml = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\SerializacaoEDesserializacao\06_Exercicio\file.xml";

List<Aluno> listaDeAlunos = new()
{
    new Aluno(10, "Marya", "marya@yahoo.com", 17),
    new Aluno(11, "Marcos", "marcos.ribeiro@yahoo.com", 15),
    new Aluno(12, "Lucas", "lucas.lima@yahoo.com", 19)
};

//Fazendo com XML
XmlSerializer sxml = new(typeof(List<Aluno>)); 
//É possível passar uma lista como tipo para a classe XmlSerializer,
//assim ele irá se preparar para comverter a lista no formato xml
using (StreamWriter write = new(pathXml))
{
    sxml.Serialize(write, listaDeAlunos);
}

//Fazendo com JSON
string lista = JsonSerializer.Serialize(listaDeAlunos); //Aqui fazemos a conversão da lista para json e depois adicionamos ela ao arquivo JSON
File.WriteAllText(pathJson, lista);

Console.WriteLine("Success!");
Console.ReadKey();