Console.WriteLine("## Classe Directory ##\n");

var caminhoDiretorio = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\03_ClasseDirectory\TestandoPasta";

var caminhoCopia = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\03_ClasseDirectory\TestandoNovo";

//Para criar um diretorio
try
{
    if (!Directory.Exists(caminhoDiretorio))
    {
        Directory.CreateDirectory(caminhoDiretorio + @"\p1");
        Directory.CreateDirectory(caminhoDiretorio + @"\p2");
        Directory.CreateDirectory(caminhoDiretorio + @"\p3");
        Directory.CreateDirectory(caminhoDiretorio + @"\p4");
        
        Console.WriteLine($"Diretorio {caminhoDiretorio} criado com sucesso");
    }
    else
    {
        Console.WriteLine($"O diretorio {caminhoDiretorio} já existe");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


//Deletar diretorio
try
{
    if (Directory.Exists(caminhoDiretorio + @"/p1"))
    {
        Directory.Delete(caminhoDiretorio + @"/p1");
        Console.WriteLine($"\nDiretorio {caminhoDiretorio + @"/p1"} deletado com sucesso");
    }
    else
    {
        Console.WriteLine($"\nO diretorio {caminhoDiretorio} não existe");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//Pegando os subdiretorios
try
{
    if (Directory.Exists(caminhoDiretorio))
    {
        string[] sub = Directory.GetDirectories(caminhoDiretorio, "h*"); 
        /*
         * O "h*"nesse contexto é um padrão (ou curinga ) que será utilizado para buscar
         * diretórios cujo nome começa com a letra "h". O asterisco ( *) significa "qualquer
         * sequência de caracteres", então a expressão "h*"irá encontrar todos os diretórios que
         * começam com "h" e podem ter qualquer sequência de caracteres após isso.
         */
        Console.WriteLine("\nsubdiretorios:");
        foreach (var item in sub)
            Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine("Não tem subdiretorios");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// Pegando todos os arquivos
try
{
    if (Directory.Exists(caminhoDiretorio))
    {
        string[] sub = Directory.GetFiles(caminhoDiretorio, "f*"); 
        Console.WriteLine("\nFiles:");
        foreach (var item in sub)
            Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine("Files");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//Movendo arquivo ou renomeando
try
{
    if (Directory.Exists(caminhoDiretorio))
    {
        Directory.Move(caminhoDiretorio, caminhoCopia);
        Console.WriteLine($"\nmovendo {caminhoDiretorio} para {caminhoCopia}");
    }
    else
    {
        Console.WriteLine("Files");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
