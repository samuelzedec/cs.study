namespace _14_Exercicio;
using Abstrata;
using Interface;
internal class SalvarXML : ArquivoBase, ISalvar
{
    public void Salvar()
        => Console.WriteLine("Salvar arquivo em XML");

    public override void Nome()
        => Console.WriteLine("Definir o nome Xml");
}
