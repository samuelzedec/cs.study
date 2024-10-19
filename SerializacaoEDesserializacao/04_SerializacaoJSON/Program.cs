using System.Text.Json;
using _04_SerializacaoJSON;
Console.WriteLine("## Serialização JSON ##");

Aluno aluno1 = new(101, "Maria", "maria@yahoo.com", 17);
string caminho = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\SerializacaoEDesserializacao\04_SerializacaoJSON\AlunoSerializado.json";

using (FileStream stream = new(caminho,
           FileMode.OpenOrCreate,
           FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, aluno1);
}

Console.WriteLine("Serialização para JSON feita com sucesso!");
Console.ReadKey();