using _14_Exercicio;
using Interface;

Console.WriteLine("## Exercício Interface ##\n");

SalvarXML xml = new();
xml.Salvar();
xml.Nome();

SalvarJSON json = new();
json.Salvar();
json.Nome();


ISalvar salvarXML = new SalvarXML();
salvarXML.Compactar();

ISalvar salvarJSON  = new SalvarJSON();
salvarJSON.Compactar();