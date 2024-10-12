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
        Console.WriteLine("[3] - Deletar dirétorio");
        Console.WriteLine("\u001b[31m[4] - Encerrar programa\u001b[0m");
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
        Console.Clear();
        Console.WriteLine($"\u001b[32mCaminho do diretório:\u001b[0m {directoryName}");
        Console.WriteLine("\nInforme o número da opção desejável:");
        Console.WriteLine("[1] - Ver informações de todos os arquivos");
        Console.WriteLine("[2] - Excluir arquivo");
        Console.WriteLine("[3] - Editar arquivo");
        Console.WriteLine("[4] - Criar arquivo");
        Console.WriteLine("\u001b[31m[5] - Voltar ao menu anterior\u001b[0m");
        Console.Write("\n\u001b[32m> \u001b[0m");
    }

    public static void FileSpecifications(FileInfo[] files)
    {
        foreach (var file in files)
        {
            Console.Clear();
            Confirmation(file);
            DocumentLines(file);
            Continue();
        }
    }

    public static void DocumentLines(FileInfo file)
    {
        var document = File.ReadAllLines(file.FullName);
        if (document.Length == 0) return;
            
        Console.WriteLine("Informações no documento: ");
        foreach (var s in document)
            Console.WriteLine($"\t{s}");
    }

    public static void ViewFileNames(FileInfo[] files)
    {
        int num = 1;
        Console.Clear();
        Console.WriteLine("\u001b[31mArquivos disponíveis:\n\u001b[0m");
        foreach (var file in files)
        {
            Console.WriteLine($"{num}. {file.Name}");
            num++;
        }
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

    public static void SuccessFileDelete()
    {
        Console.Clear();
        Console.WriteLine("\u001b[32mArquivo deletado com sucesso!\u001b[0m");
        Continue();
    }
    
    public static void SuccessFileCreate()
    {
        Console.Clear();
        Console.WriteLine("\u001b[32mArquivo criado com sucesso!\u001b[0m");
        Continue();
    }

    public static void ReportFile()
    {
        Console.Clear();
        Console.WriteLine("letras iniciais: [AA - AB - AC]");
        Console.Write("Informe as duas letras iniciais do arquivo: ");
    }

    public static void Notepad()
    {
        Console.Clear();
        Console.WriteLine("\u001b[42m\u001b[30mVocê irá abrir o bloco de notas!\u001b[0m");
        Continue();
    }

    public static void KillNotepad()
    {
        Console.Clear();
        Console.WriteLine("\u001b[32mEncerrar notepad!\u001b[0m");
        Continue();
    }

    public static void ViewAcronyms(params string[] acronyms)
    {
        Console.Clear();
        Console.WriteLine("Informe a sigla que deseja usar:");
        foreach (var acronym in acronyms)
            Console.WriteLine($"\t- {acronym}");
        Console.Write("\n\u001b[32m> \u001b[0m");
    }

    public static void NameFile()
    {
        Console.Clear();
        Console.Write("Informe o nome do arquivo que você deseja criar: ");
    }

    public static void ExisingFile(string file)
    {
        Console.Clear();
        Console.WriteLine($"O arquivo {file}, já existe! Tente novamente...");
        Continue();
    }

    public static void RepositoryName()
    {
        Console.Clear();
        Console.Write("Informe o nome do seu repositório: ");
    }

    public static void CreationCompleted()
    {
        Console.Clear();
        Console.WriteLine("\u001b[32mCriação do seu repositório feita com sucesso!\u001b[0m");
        Continue();
    }

    public static void DeletingRepository(DirectoryInfo[] directories)
    {
        int i = 1;
        Console.Clear();
        Console.WriteLine("Informe o índice do repositório que deseja excluir");
        foreach (var info in directories)
        {
            Console.WriteLine($"\t{i}. {info.Name}");
            i++;
        }
        Console.Write("\n\u001b[32m> \u001b[0m");
    }

    public static void RepositoryDeleteWithSuccess()
    {
        Console.Clear();
        Console.WriteLine("\u001b[32mDiretório deletado com sucesso!\u001b[0m");
        Continue();
    }

    public static void ConfirmationDeleteRepository(DirectoryInfo path)
    {
        Console.Clear();
        Console.WriteLine("\u001b[31mInformação do diretório:\u001b[0m\n");
        Console.WriteLine($"Nome: {path.Name}");
        Console.WriteLine($"Caminho: {path.FullName}");
        Console.WriteLine($"Arquivos: {path.GetFiles().Length}");
    }
}