Console.WriteLine("## Classe FileStream ##\n");
string caminhoArquivo = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\06_FIleStream\ConstrutoresFileStream.txt";

try
{
    /*//Using padrão
    using (FileStream fs = new(caminhoArquivo, FileMode.Open, FileAccess.Read))
    {
        using (StreamReader leitor = new(fs))
        {
            string? linha;
            while ((linha = leitor.ReadLine()) != null)
                Console.WriteLine(linha);
        }
    }*/
    
    //Using apartir do c# na versão 8
    //using FileStream fs = new(caminhoArquivo, FileMode.Open, FileAccess.Read);
    //using StreamReader leitor = new(fs);

    using var leitor = File.OpenText(caminhoArquivo);
    string? linha;
    while ((linha = leitor.ReadLine()) != null)
        Console.WriteLine(linha);
}
catch (IOException ex)
{
    Console.WriteLine(ex);
}



/*
 * Fazendo com o método .Close()
FileStream? fs = null;
StreamReader? leitor = null;

try
{
    //fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
    leitor = File.OpenText(caminhoArquivo); // File.OpenText(): retornar uma StreamReader

    string? linha;
    while ((linha = leitor.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    if(leitor != null) leitor.Close();
    //if(fs != null) fs.Close();
}*/