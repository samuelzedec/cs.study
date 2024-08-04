using System.Collections;

namespace EX3;

public partial class FilaDeEspera
{
    ArrayList lista = new();

    private string Nomes()
    {
        string nomes = "\nLista de Paciente:\n";
        for(int i = 0; i < lista.Count; i++)
        {
            nomes += $"{i + 1}. {lista[i]}\n";
        }
        return nomes;
    }

    private string Escolha()
    {
        string menu = "[1] - Adicionar Paciente \n[2] - Atender Paciente \n[3] - Atendimento Preferencial \n[4] - Remover Paciente \n[5] - Limpar Fila \n[6] - Encerrar programa";

        return menu;
    }

    private void Escolha(int num)
    {
        switch(num)
        {
            case 1:
                Adicionar();
                break;
            case 2:
                Atender();
                break;
            case 3:
                AtendimentoPreferencial();
                break;
            case 4:
                RemoverPaciente();
                break;
            case 5:
                LimparFila();
                break;
            case 6:
                Console.WriteLine("Programa Encerrado...");
                break;
            default:
                Console.WriteLine("Opção Incorreta\n");
                break;
        }
    }

    private void Adicionar()
    {
        Console.Clear();
        Console.Write("Informe o nome do paciente: ");
        string? nome = Console.ReadLine()?.ToUpper();

        lista.Add(nome);
        Console.WriteLine("Paciente adicionado com sucesso a fila de espera\n");
    }

    private void Atender()
    {
        Console.Clear();
        if (lista[0] != null)
        {
            Console.WriteLine($"Paciente {lista[0]} atendido...\n");
            lista.RemoveAt(0);
        }
        else
        {
            Console.WriteLine("Não há paciente na fila de espera\n");
        }
    }

    private void AtendimentoPreferencial()
    {
        Console.Clear();
        Console.Write("Informe o nome do paciente que deseja atender de imediato: ");
        string? nomePreferencial = Console.ReadLine()?.ToUpper();

        if(lista.Contains(nomePreferencial))
        {
            lista.Remove(nomePreferencial);
            Console.WriteLine("Paciente atendido de imediato...\n");
        }
        else
        {
            Console.WriteLine("Paciente não encontrado na fila de espera\n");
        }
    }

    private void LimparFila()
    {
        Console.Clear();
        Console.WriteLine("Fila limpa com sucesso...\n");
        lista.Clear();
    }

    private void RemoverPaciente()
    {
        Console.Clear();
        Console.Write("Informe o nome do paciente: ");
        string? nome = Console.ReadLine()?.ToUpper();

        if (lista.Contains(nome))
        {
            lista.Remove(nome);
            Console.WriteLine("Paciente removido...\n");
        }
        else
        {
            Console.WriteLine("Paciente não encontrado...\n");
        }
    }
}

