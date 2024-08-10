namespace EX4.Entities;

public partial class Database
{
    private static List<TaskMenu> listaTask = new()
    {
        new TaskMenu("Implementar Validação de Formulário", "Adicionar validação ao formulário de registro de usuário para garantir que todos os campos obrigatórios sejam preenchidos e que o formato do e-mail seja válido. A validação deve ocorrer tanto no lado do cliente quanto no lado do servidor. Atualizar a interface para exibir mensagens de erro apropriadas em caso de entradas inválidas.", 90, 'A'),

        new TaskMenu("Refatorar Função de Pesquisa", "Refatorar a função de pesquisa existente para melhorar a eficiência e a legibilidade do código. A função deve ser otimizada para reduzir o tempo de resposta e lidar melhor com grandes volumes de dados. Além disso, adicionar comentários explicativos e criar testes unitários para garantir que a refatoração não introduza novos bugs.", 7, 'B'),

        new TaskMenu("Adicionar Funcionalidade de Login Social", "Implementar a funcionalidade de login social utilizando o OAuth para permitir que os usuários se registrem e façam login usando suas contas do Google ou Facebook. Integrar com a API do OAuth, adicionar botões de login social na página de login, e garantir que a autenticação e o gerenciamento de sessões funcionem corretamente. Atualizar a documentação para incluir instruções sobre como configurar as credenciais do OAuth para desenvolvimento e produção.", 11, 'C')
    };

    public static void VerTodasAsTask()
    {
        var ClasseA = listaTask.FindAll(x => x.Prioridade == 'A');
        var ClasseB = listaTask.FindAll(x => x.Prioridade == 'B');
        var ClasseC = listaTask.FindAll(x => x.Prioridade == 'C');

        Console.WriteLine("## Prioridade nível A ##");
        foreach (var element in ClasseA)
        {
            Console.WriteLine($"\nCódigo: {element.Codigo}");
            Console.WriteLine($"Nome: {element.Task}");
            Console.WriteLine($"Prioridade: {element.Prioridade}");
            Console.WriteLine($"Devs trablhando nessa task: {element.equipe.Count}");

        }

        Console.WriteLine("\n## Prioridade nível B ##");
        foreach (var element in ClasseB)
        {
            Console.WriteLine($"\nCódigo: {element.Codigo}");
            Console.WriteLine($"Nome: {element.Task}");
            Console.WriteLine($"Prioridade: {element.Prioridade}");
            Console.WriteLine($"Devs trablhando nessa task: {element.equipe.Count}");

        }

        Console.WriteLine("\n## Prioridade nível C ##");
        foreach (var element in ClasseC)
        {
            Console.WriteLine($"\nCódigo: {element.Codigo}");
            Console.WriteLine($"Nome: {element.Task}");
            Console.WriteLine($"Prioridade: {element.Prioridade}");
            Console.WriteLine($"Devs trablhando nessa task: {element.equipe.Count}");

        }

        Console.ReadKey();
        Console.Clear();
    }

    public static void CadastrarTask()
    {
        Console.Write("Informe o nome da task: ");
        string? task = Console.ReadLine();

        Console.Write("Crie uma descrição para a task: \n> ");
        string? descricao = Console.ReadLine();

        Console.Clear();

        int dias;
        try
        {
            Console.Write("Quanto dias para o prazo de entrega: ");
            dias = Convert.ToInt32(Console.ReadLine());
        } catch
        {
            dias = 1;
        }

        Console.Write("Prioridade da task (Informe A, B ou C): ");
        char op = Console.ReadKey().KeyChar;
        char escolha = char.ToUpper(op);

        if(!(escolha == 'A' || escolha == 'B' || escolha == 'C'))
        {
            escolha = 'C';
        }
        Console.Clear();
        Console.WriteLine("Task Cadastrada com sucesso...\n");

        listaTask.Add(new TaskMenu(task, descricao, dias, escolha));
    }

    public static void TaskCompleta()
    {
        int code;
        try
        {
            Console.Write("Informe o código da task que deseja saber mais: ");
            code = Convert.ToInt32(Console.ReadLine());
        } catch
        {
            code = 0;
        }

        var i = listaTask.FindIndex(x => x.Codigo == code);

        if(i >= 0)
        {
            Console.WriteLine($"\nTask: {listaTask[i].Task}");
            Console.WriteLine($"Data criada: {listaTask[i].Criado.ToLongDateString()}");
            Console.WriteLine($"Entrega: {listaTask[i].Entrega.ToLongDateString()}");
            Console.WriteLine($"Prioridade: {listaTask[i].Prioridade}");
            Console.WriteLine($"Código: {listaTask[i].Codigo}");

            Console.WriteLine($"\nDescrição: {listaTask[i].Descricao}");
            Console.WriteLine($"\nDevs envolvido na task: {listaTask[i].equipe.Count}\n");

            var equipe = listaTask[i].equipe;

            foreach (var dev in equipe)
            {
                Console.WriteLine($"Nome: {dev.Nome} | ID: {dev.ID} | Cargo: {dev.Cargo}");
            }

            Console.ReadKey();
            Console.Clear();
        } else
        {
            Console.WriteLine("task não cadastrada na database\n");
        }
    }

    public static void ConcluirTask()
    {
        int code;

        try
        {
            Console.Write("Informe o código da task: ");
            code = Convert.ToInt32(Console.ReadLine());
        } catch
        {
            code = 0;
        }

        var i = listaTask.FindIndex(x => x.Codigo == code);

        if(i >= 0)
        {
            Console.WriteLine("Deseja marca como concluida a task: \n");

            Console.WriteLine($"\nTask: {listaTask[i].Task}");
            Console.WriteLine($"Data criada: {listaTask[i].Criado.ToLongDateString()}");
            Console.WriteLine($"Entrega: {listaTask[i].Entrega.ToLongDateString()}");
            Console.WriteLine($"Prioridade: {listaTask[i].Prioridade}");
            Console.WriteLine($"\nDescrição: {listaTask[i].Descricao}");
            Console.WriteLine($"\nQuantidade de devs na task: {listaTask[i].equipe.Count}");


            Console.WriteLine("\nA. Sim");
            Console.WriteLine("B. Não");
            Console.Write("> ");

            char op = Console.ReadKey().KeyChar;
            char escolha = char.ToUpper(op);

            if(escolha == 'A')
            {
                Console.Clear();
                listaTask.RemoveAt(i);
                Console.WriteLine("Task marcada como concluída...\n");
            } else
            {
                Console.Clear();
                Console.WriteLine("Task não marcada como concluída...\n");
            }

        } else
        {
            Console.WriteLine("task não cadastrada na database\n");
        }

    }

    public static void RemoverDevDaTask()
    {
        int code;
        try
        {
            Console.Write("Informe o código da task: ");
            code = Convert.ToInt32(Console.ReadLine());
        } catch
        {
            code = 0;
        }

        var i = listaTask.FindIndex(x => x.Codigo == code);

        if(i >= 0)
        {
            Console.WriteLine($"\nTask: {listaTask[i].Task}");
            Console.WriteLine("\nDevs envolvido na task: ");

            var equipe = listaTask[i].equipe;
            foreach (var dev in equipe)
            {
                Console.WriteLine($"Nome: {dev.Nome} | ID: {dev.ID} | Cargo: {dev.Cargo}");
            }

            int id;
            try
            {
                Console.Write("Informe o ID do Dev que deseja remover da task: ");
                id = Convert.ToInt32(Console.ReadLine());
            } catch
            {
                id = 0;
            }
            var devId = listaTask[i].equipe.FindIndex(x => x.ID == id);

            if(devId >= 0)
            {
                Console.Clear();
                Console.WriteLine("Dev removida da task...\n");
                listaTask[i].equipe.RemoveAt(devId);
            } else
            {
                Console.Clear();
                Console.WriteLine("Você informou o ID incorreto\n");
            }

        } else
        {
            Console.Clear();
            Console.WriteLine("task não cadastrada na database\n");
        }
    }


    public static void CadastrarDevEmUmaTask()
    {
        int code;

        try
        {
            Console.WriteLine("Informe o código da task: ");
            code = Convert.ToInt32(Console.ReadLine());
        } catch
        {
            code = 0;
        }

        var i = listaTask.FindIndex(x => x.Codigo == code);

        if(i >= 0)
        {
            var pleno = listaDev.FindAll(x => x.Cargo == "PLENO");
            var senior = listaDev.FindAll(x => x.Cargo == "SÊNIOR");
            var junior = listaDev.FindAll(x => x.Cargo == "JUNIOR");

            Console.WriteLine("\n## Sênior ##");
            foreach (var dev in senior)
            {
                Console.WriteLine($"ID: {dev.ID} | Nome: {dev.Nome}");
            }

            Console.WriteLine("\n## Pleno ##");
            foreach (var dev in pleno)
            {
                Console.WriteLine($"ID: {dev.ID} | Nome: {dev.Nome}");
            }

            Console.WriteLine("\n## Junior ##");
            foreach (var dev in junior)
            {
                Console.WriteLine($"ID: {dev.ID} | Nome: {dev.Nome}");
            }

            int idDev;
            try
            {
                Console.Write("\nInforme o código do dev que vc deseja adicionar a task: ");
                idDev = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                idDev = 0;
            }

            var devEscolhido = listaDev.Find(x => x.ID == idDev);

            if(devEscolhido != null)
            {
                listaTask[i].equipe.Add(devEscolhido);
                Console.Clear();
                Console.WriteLine("Dev adicionado para task...\n");
            } else
            {
                Console.Clear();
                Console.WriteLine("Você informou o ID incorreto...\n");
            }
        } else
        {
            Console.Clear();
            Console.WriteLine("Task não encontrada na Database...\n");
        }
    }
}

