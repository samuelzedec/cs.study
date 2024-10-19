using System.Runtime.Serialization.Formatters.Binary;
using _01_SerializacaoBinaria;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Serialização Binária ##");
        Aluno aluno1 = new(101, "Maria", "maria@yahoo.com", 17);

        var caminho = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\SerializacaoEDesserializacao\01_SerializacaoBinaria\AlunoSerializado.bin";

        using (FileStream stream = new(
            caminho,
            FileMode.OpenOrCreate,
            FileAccess.ReadWrite
        ))
        {
            //O uso do pragma faz com que rode o BinaryFormatter();
            #pragma warning disable SYSLIB0011
            var bf = new BinaryFormatter();
            bf.Serialize(stream, aluno1);
            #pragma warning disable SYSLIB0011
            //Não é possivel rodar no dotnet 8, teria que voltar para a versão 7 do dotnet e usar o C# na versão 10
            
            Console.WriteLine("Tecle algo para realizar a Desserialização");
            Console.ReadKey();

            // Move o ponteiro do fluxo para o início do arquivo, preparando para ler ou escrever a partir do começo.
            stream.Seek(0, SeekOrigin.Begin);
            var alunoDesserializado = (Aluno)bf.Deserialize(stream);
            
        }
    }
}