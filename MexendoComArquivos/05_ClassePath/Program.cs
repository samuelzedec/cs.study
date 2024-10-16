Console.WriteLine("## Classe Path ##\n");

string path1 = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\05_ClassePath\Directory1";
string path2 = @"txt\poesia.txt";

string pathCombinado = Path.Combine(path1, path2);
Console.WriteLine($"Path combinado: {pathCombinado}");

//Métodos que precisam de parâmetro
Console.WriteLine($"Nome do diretório: {Path.GetDirectoryName(pathCombinado)}");
Console.WriteLine($"Extensão: {Path.GetExtension(pathCombinado)}");
Console.WriteLine($"Nome do arquivo: {Path.GetFileName(pathCombinado)}");
Console.WriteLine($"Nome do arquivo sem extensão: {Path.GetFileNameWithoutExtension(pathCombinado)}");
Console.WriteLine($"Possui extensão? {Path.HasExtension(pathCombinado)}");
Console.WriteLine($"Contém a raiz? {Path.IsPathRooted(pathCombinado)}");
Console.WriteLine($"Nova extensão do arquivo: {Path.ChangeExtension(pathCombinado, ".docx")}");
Console.WriteLine($"Raiz: {Path.GetPathRoot(pathCombinado)}");

//Não precisam de parâmetro
Console.WriteLine($"Nome de arquivo aleatório: {Path.GetRandomFileName()}");
Console.WriteLine($"Nome de arquivo temporário: {Path.GetTempFileName()}");
Console.WriteLine($"Caminho temporário: {Path.GetTempPath()}");

//Caracteres Inválidos
char[] caracteresInvalidosEmArquivos = Path.GetInvalidFileNameChars();
Console.WriteLine($"Caracteres Inválidos: {new string(caracteresInvalidosEmArquivos)}");