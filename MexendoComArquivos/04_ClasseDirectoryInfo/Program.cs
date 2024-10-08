Console.WriteLine("## Classe DirectoryInfo ##\n");

var caminhoDiretorio = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\04_ClasseDirectoryInfo\NewDirectory";

DirectoryInfo dirOrigem = new(caminhoDiretorio);

//Algumas das principais propriedades:
Console.WriteLine($"Nome do diretório: {dirOrigem.Name}");
Console.WriteLine($"Caminho completo: {dirOrigem.FullName}");
Console.WriteLine($"Data de criação: {dirOrigem.CreationTime}");
Console.WriteLine($"Último acesso: {dirOrigem.LastAccessTime}");
Console.WriteLine($"Última modifiação: {dirOrigem.LastWriteTime}");
Console.WriteLine($"Atributos: {dirOrigem.Attributes}");

Console.WriteLine("\nCriando um novo diretório");
DirectoryInfo novoDir = new(caminhoDiretorio + @"\NovoDiretorio");
try
{
    if (!novoDir.Exists)
    {
        novoDir.Create();
        Console.WriteLine($"\tDiretório {novoDir.Name} criado!");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine($"\nExcluindo novo diretório: {novoDir.Name} ");
try
{
    if (novoDir.Exists)
    {
        Console.WriteLine($"\tDiretório {novoDir.Name} excluído");
        novoDir.Delete();
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\nExibindo subdiretórios:");
try
{
    var arrInfo = dirOrigem.GetDirectories();
    foreach (var info in arrInfo)
        Console.WriteLine($"\tpasta: {info.Name}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\nExibindo files:");
try
{
    var arrInfo = dirOrigem.GetFiles();
    foreach (var info in arrInfo)
        Console.WriteLine($"\tpasta: {info.Name}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine($"Criando novo subdiretorio");
try
{
    dirOrigem.CreateSubdirectory("subDiretorio");
    Console.WriteLine("Success");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}