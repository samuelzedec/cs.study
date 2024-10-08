Console.WriteLine("## Classe File ##");

string path = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\01_ClassFile\Directory\arquivo.txt";

//Criando arquivo
/*
 * File.Create(path);
 * Não é possível usar o Create, junt  o com o código abaixo
 * Porque ao criar o arquivo, ele o mantém aberto na memória
 */

//Criando o arquivo, escrevendo no arquivo e fechando o arquivo
File.WriteAllText(path, "Nome: Samuel Zedec\r\n" + // \r\n: serve para quebrar linha no arquivo que tenha .txt
                        "Idade: 19\r\n" +
                        "Cidade: Manaus\r\n" +
                        "Cargo: Desenvolvedor C# .NET\r\n");

string complemento = "Empresa: Microsoft\r\n" +
                     Environment.NewLine +
                     $"Salário: {3231.56m:C2}";

/*
 * Environment.NewLine é uma propriedade em C# que retorna a sequência de caracteres
 * apropriada para a nova linha do ambiente atual. Essa sequência é usada para garantir
 * que o código seja compatível com diferentes sistemas operacionais ao lidar com quebras de linha em strings.
*/
 
//Escrevendo mais no arquivo
File.AppendAllText(path, complemento);

//Lê o conteúdo do arquivo
Console.WriteLine("\nConteúdo e informações do arquivo:");

// Irá abrir o arquivo, retorna tudo em string e fechar o arquivo
string conteudo = File.ReadAllText(path);
Console.WriteLine(conteudo);

//Acessando a última modificção do arquivo
Console.WriteLine($"\nÚltima modificação feita em: {File.GetLastWriteTime(path)}");

//Acessando o último acesso
Console.WriteLine($"Úlitmo acesso: {File.GetLastAccessTime(path)}");

//Armazenando cada linha em um array de string
Console.WriteLine("\nGuardando cada linha em um array de string:");
string[] linhas = File.ReadAllLines(path);
foreach (var linha in linhas)
    Console.WriteLine(linha);

//Copiando arquivo
string copyPath = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\01_ClassFile\Directory\arquivoCopia.txt";

Console.WriteLine($"\nOriginal: {path} \nCópia: {copyPath}");
File.Copy(path, copyPath);

//Movendo arquivo
string path2 = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\01_ClassFile\txt\arquivo.txt";
Console.WriteLine($"\nMovendo: {path} \nPara: {path2}");
File.Move(path, path2);

//Excluir
File.Delete(copyPath);
File.Delete(path2);
File.Delete(path);

    
