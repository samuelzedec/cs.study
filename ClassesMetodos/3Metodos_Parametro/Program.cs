Console.WriteLine("## Métodos com Parâmetros ##\n");
MinhaClasse teste = new();

string nome = "Maria";
string dataAtual = DateTime.Now.ToLongDateString();


teste.Saudacao(nome, dataAtual);

public class MinhaClasse
{
    public void Saudacao(string nome, string data) {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}
