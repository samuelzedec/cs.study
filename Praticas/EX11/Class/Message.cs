namespace Class.GlobalMessage;

public static class GlobalMessage
{
    public static void Welcome()
    {
        Console.Clear();
        Console.WriteLine("\u001b[32m## Olá, Seja bem-vindo ao Gerenciador de Notas ##\u001b[0m");
        Console.WriteLine("\nAqui está um exercício que fiz para praticar as classes Process, FileInfo e DictionaryInfo. Entre outras coisas que aprendi ultimamente. Farei o possivel para organizar o código para que fique legível. Fiz também para praticar alguns conceitos de exceções, mesmo que alguns sejam redundantes, fiz mais para lembrar seu conceito e praticar");
        Continue();
    }

    public static void Continue()
    {
        Console.Write("\n\u001b[36m\u001b[1m\u001b[3m- Pressione enter para continuar\u001b[0m");
        Console.ReadKey();
    }

    public static void DefaultMenuOptions()
    {
        Console.Clear();
        Console.WriteLine("\u001b[35m\u001b[1m" +
                          "Bem-Vindo ao menu inicial! Informe o número da opção desejável:" +
                          "\u001b[0m");
        Console.WriteLine("[1] - Acessar dirétorio");
        Console.WriteLine("[2] - Criar dirétorio");
        Console.WriteLine("[3] - Acessar arquivos de um diretório");
        Console.WriteLine("[4] - Criar novo arquivo em um diretório");
        Console.WriteLine("[5] - Opções de Navegador");
        Console.WriteLine("\u001b[31m[6] - Encerrar programa\u001b[0m");
        Console.Write("\n> ");
    }

    public static void IncorrectChoices()
    {
        Console.Clear();
        Console.WriteLine("\u001b[31mOpção incorreta! Tente outra opção...\u001b[0m");
        Continue();
    }

    public static void BackToMainMenu()
    {
        Console.Clear();
        Console.WriteLine("\u001b[31m< Voltando ao menu inicial! >\u001b[0m");
        Continue();
    }

    public static void EndProgram()
    {
        Console.Clear();
        Console.WriteLine("\u001b[42m\u001b[30m\u001b[3m[    Obrigado por testar!    ]\u001b[0m");
    }

    public static void ShowAvailable(DirectoryInfo[] availableDirectories)
    {
        Console.Clear();
        Console.WriteLine("Diretórios disponíveis: ");
        int i = 1;

        foreach (var directory in availableDirectories)
        {
            Console.WriteLine($"\t{i}. {directory.Name}");
            i++;
        }
        Console.Write("\nInforme o digíto do reposiório você deseja acessar (digite 0 para nenhum): ");
    }

    public static void DirectoryMenu(string directoryName)
    {
        Console.WriteLine($"\u001b[32mCaminho do diretório:\u001b[0m {directoryName}");
        Console.WriteLine("\nInforme o número da opção desejável:");
        Console.WriteLine("[1] - Ver informações de todos os arquivos");
        Console.WriteLine("[2] - Excluir arquivo");
        Console.WriteLine("[3] - Editar arquivo");
        Console.WriteLine("[5] - Voltar ao menu anterior");
        Console.WriteLine("\n\u001b[32m> \u001b[0m");
    }

    public static void FileSpecifications(FileInfo[] files)
    {
        foreach (var file in files)
        {
            Console.Clear();
            Confirmation(file);
            Continue();
        }
    }

    public static void ViewFileNames(FileInfo[] files)
    {
        int num = 1;
        Console.Clear();
        foreach (var file in files)
            Console.WriteLine($"{num}. {file.Name}");

        Console.Write("Informe o índice do arquivo: ");
    }

    public static void Confirmation(FileInfo file)
    {
        Console.Clear();
        Console.WriteLine("\u001b[31mInformação do arquivo:\u001b[0m\n");
        Console.WriteLine($"Nome do arquivo: {file.Name}" +
                          $"\nData de crição: {file.CreationTime}" +
                          $"\nÚltimo acesso {file.LastAccessTime}" +
                          $"\nÚltimo modificação: {file.LastWriteTime}" +
                          $"\nCaminho completo: \u001b[33m{file.FullName}\u001b[0m");
    }

    public static void SuccessFile()
    {
        Console.Clear();
        Console.WriteLine("\u001b[32mArquivo deletado com sucesso!\u001b[0m");
        Continue();
    }
}