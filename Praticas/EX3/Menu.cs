namespace EX3;

public partial class FilaDeEspera
{
    public void Menu()
    {
        byte escolha;

        do
        {
            Console.WriteLine("Olá, Seja bem-vindo!");
            Console.WriteLine(Nomes());

            Console.WriteLine("Informe o que deseja fazer: ");
            Console.WriteLine(Escolha());

            try
            {
                Console.Write("\nInforme o número da opção desejada: ");
                escolha = Convert.ToByte(Console.ReadLine());
            } catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                escolha = 0;
            }
            Escolha(escolha);
        } while (escolha != 6);
    }
}

