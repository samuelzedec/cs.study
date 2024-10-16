Action<string> criarArquivo = (value) =>
{
    try
    {
        using FileStream file = new(
            value, 
            FileMode.Create, 
            FileAccess.Write);

        Console.WriteLine($"\n>> Arquivo {value} foi criado <<");
    }
    catch (IOException e)
    {
        Console.WriteLine(e.Message);
    }
};

Action<string> gravarArquivo = delegate(string value)
{
    Console.WriteLine("Informe o texto que deseja gravar no arquivo: ");
    string text = Console.ReadLine() ?? String.Empty;

    try
    {
        //true: significa que ele irá escrever o texto no final do arquivo e não sobrescrever tudo
        using StreamWriter writer = new StreamWriter(value, true);
        writer.WriteLine(text);
    }
    catch (IOException e)
    {
        Console.WriteLine(e.Message);
    }
};

Action<string> lerArquivo = (value) =>
{
    if (!File.Exists(value))
    {
        Console.WriteLine("Arquivo não existe");
        return;
    }

    try
    {
        using StreamReader sr = new(value);
        string? linha;
        while((linha = sr.ReadLine()) != null) Console.WriteLine(linha);

    }
    catch (IOException e)
    {
        Console.WriteLine(e.Message);
    }
    
};

Action<string> procurarTexto = (value) =>
{
    if (!File.Exists(value))
    {
        Console.WriteLine("Arquivo não existe");
        return;
    }
    Console.WriteLine("\nDigite o texto a ser procurado:");
    string? text = Console.ReadLine();

    try
    {
        bool encontrado = false;
        
        using StreamReader sr = new(value);
        string? linha;
        int numLinha = 0;
        while ((linha = sr.ReadLine()) != null)
        {
            numLinha++;
            if (linha.Contains(text)) encontrado = true;

            if (encontrado)
            {
                Console.WriteLine($"Texto encontrado na linha {numLinha} \nTexto completo: {linha}");
                encontrado = false;
            }
            else
                Console.WriteLine("Texto não encontrado3");
        }


    }
    catch (IOException e)
    {
        Console.WriteLine(e.Message);
    }
};

string filePath = @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\MexendoComArquivos\07_Exercicio_Stream\exercicio.txt";

Console.WriteLine($"Caminho do arquivo a ser criado: {filePath}");
while (true)
{
    Console.WriteLine("\nSelecione uma opção:");
    Console.WriteLine("1 - Criar arquivo");
    Console.WriteLine("2 - Gravar em arquivo");
    Console.WriteLine("3 - Ler arquivo");
    Console.WriteLine("4 - Procurar texto no arquivo");
    Console.WriteLine("0 - sair");

    bool opcao = int.TryParse(Console.ReadLine(), out int value);

    switch (value)
    {
        case 0:
            return;
        case 1:
            criarArquivo(filePath);
            break;
        case 2:
            gravarArquivo(filePath);
            break;
        case 3:
            lerArquivo(filePath);
            break;
        case 4:
            procurarTexto(filePath);
            break;
        default:
            Console.WriteLine("Opção Inválida...");
            break;
    }
}

