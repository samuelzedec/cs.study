namespace _14_Exercicio;
using Abstrata;
using Interface;
internal class SalvarJSON : ArquivoBase, ISalvar
{
    public void Salvar()
        => Console.WriteLine("Salvar Arquivo JSON");

    public override void Nome()
        => Console.WriteLine("Definir nome JSON");
}
