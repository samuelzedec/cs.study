using System.Xml.Serialization;
using _03_DesserializacaoXML;
Console.WriteLine("## Desserialização XML ##");

string caminho = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\SerializacaoEDesserializacao\02_SerializacaoXML\AlunoSerializado.xml";
XmlSerializer serializer = new(typeof(Aluno));

using (StreamReader reader = new(caminho))
{
    var aluno = (Aluno)serializer.Deserialize(reader);
    Console.WriteLine($"Aluno XML desserializado: \n\tID: {aluno.Id} \n\tNome: {aluno.Name} \n\tEmail: {aluno.Email} \n\tIdade: {aluno.Age}");
}

Console.ReadKey();

