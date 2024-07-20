class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Valor da compra: R$600,00");
        // Console.Write("Informe o número de parcelas (1 à 3): ");
        // int prestacao = Convert.ToInt32(Console.ReadLine());

        // switch(prestacao) {
        //     case 1: 
        //         Console.WriteLine("Valor da prestação: 1x de R$ 600,00");
        //         break;
        //     case 2:
        //         Console.WriteLine("Valor da prestação: 2x de R$ 300,00");
        //         break;
        //     case 3:
        //         Console.WriteLine("Valor da prestação: 3x de R$ 200,00");
        //         break;
        //     default:
        //         Console.WriteLine("Digite uma opção válida!");
        //         break;
        // }

        // Console.Write("Informe um número inteiro: ");
        // int numero = Convert.ToInt32(Console.ReadLine());

        // switch(numero % 2) {
        //     case 0:
        //         Console.WriteLine($"{numero} é par");
        //         break;
        //     case 1:
        //         Console.WriteLine($"{numero} é impar");
        //         break;
        // }

        // Console.WriteLine("Encerrando o programa...");

        // Console.Write("Informe um número de prestações (1 à 6): ");
        // var prestacoes = Convert.ToInt32(Console.ReadLine());

        // switch(prestacoes) {
        //     case 1:
        //     case 2:
        //     case 3:
        //         Console.WriteLine("Não tem juros");
        //         break;
        //     case 4:
        //     case 5:
        //     case 6:
        //         Console.WriteLine("Juros aplicado");
        //         break;
        // }

        // var mes = Console.ReadLine()?.ToLower();
        // switch(mes) {
        //     case "janeiro":
        //     case "março":
        //     case "maio":
        //     case "julho":
        //     case "agosto":
        //     case "outubro":
        //     case "dezembro":
        //         Console.WriteLine("Este mês tem 31 dias");
        //         break;
        //     case "fevereiro":
        //         Console.WriteLine("Este mês tem 28 ou 29 dias");
        //         break;
        //     default:
        //         Console.WriteLine("Este mês tem 30 dias");
        //         break;
        // }

        Console.WriteLine("Digite o número do seu cargo: \n[1] - Gerente \n[2] - Programador");
        int cargo = Convert.ToInt32(Console.ReadLine());
        int funcao = 0;

        if(cargo == 2) {
            Console.WriteLine("Digite o número que refere a sua função: \n[1] - Junior \n[2] - Sênior");

            funcao = Convert.ToInt32(Console.ReadLine());
        }

        switch(cargo) {
            case 1:
                Console.WriteLine("Você é gerente, Seja Bem-vindo!");
                break;
            case 2:
                Console.WriteLine("Bem-Vindo programdor...\n");
                switch(funcao) {
                    case 1: 
                        Console.WriteLine("Você é Junior");
                        break;
                    case 2: 
                        Console.WriteLine("Você é Sênior");
                        break;
                    default:
                        Console.WriteLine("Função não encotrada");
                        break;
                }
                break;
            default:
                Console.WriteLine("Cargo não encontrado");
                break;
        }
    }
}