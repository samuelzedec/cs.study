Console.WriteLine("## Métodos ##\n");
MinhaClasse function = new();

function.Saudacao();

class MinhaClasse
{
    public void Saudacao() {
        Console.WriteLine("Bem-vindo!");
        ExibirData();
    }

    private void ExibirData() =>
        Console.WriteLine(DateTime.Now.ToShortDateString());

}
