Console.WriteLine("## Classe FileInfo ##");

var path = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\02_ClasseFileInfo\Dados\poesia.txt";
var pathDestination = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\02_ClasseFileInfo\txt\poesia.txt";
var pathCopy = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\02_ClasseFileInfo\Dados\poesiaCopia.txt";

FileInfo arquivo = new(path);

Console.WriteLine($"\n\tNome do {nameof(arquivo)}: {arquivo.Name}");

Console.WriteLine($"\n\tCaminho completo do {nameof(arquivo)}: {arquivo.FullName}");

Console.WriteLine($"\n\tO {nameof(arquivo)} é somente leitura: {arquivo.IsReadOnly}");

var pathDaddy = arquivo.Directory;
Console.WriteLine($"\n\tNome do dirétorio: {pathDaddy?.Name}");

Console.WriteLine($"\n\tTamanho do {nameof(arquivo)}: {arquivo.Length} bytes");

Console.WriteLine($"\n\tÚltima gravação: {arquivo.LastWriteTime}");

if (arquivo.Exists)
{
    Console.WriteLine($"\n\tO {path} arquivo existe. Copiando para Copiando para {pathCopy}");
    arquivo.CopyTo(pathCopy);
}
else
{
    Console.WriteLine($"\n\tO {path} não existe");
}

Console.WriteLine($"\n\tMovendo {path} para a {pathDestination}");
arquivo.MoveTo(pathDestination);