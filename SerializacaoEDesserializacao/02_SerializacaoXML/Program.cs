using System.Xml.Serialization;
using _02_SerializacaoXML;
Console.WriteLine("## Serialização em XML ##");

string caminho = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\SerializacaoEDesserializacao\02_SerializacaoXML\AlunoSerializado.xml";
Aluno aluno1 = new(101, "Maria", "maria@yahoo.com", 17);

//Aqui estamos passando pro XmlSeralizer o tipo que iremos seralizar, que no caso é do tipo Aluno
XmlSerializer serializer = new(typeof(Aluno));

// Cria um arquivo ou sobrescreve o existente
using (StreamWriter writer = new(caminho))
{
    /*
     * Aqui vamos serializar para o arquivo xml
     * 1º Parâmetro: Passar o arquivo xml que irá armazenar a informação
     * 2º Parâmetro: O que será serializado para o arquivo XML
     */
    serializer.Serialize(writer, aluno1);
}

Console.WriteLine("Objeto serializado para XML com sucesso!");
Console.ReadKey();