using _11_Operador_Is_As;

Console.WriteLine("## Operador Is e Operador As ##\n");
Circulo circulo = new();
Forma forma = circulo;

if(forma is Circulo)
{
    Console.WriteLine("Converteu Forma para Circulo");

    //((Circulo)forma).PintarCirculo();
    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
} else
{
    Console.WriteLine("Operação de downcasting não é possível");
}




//Circulo c = (Circulo)forma;
//Circulo c = forma as Circulo; //downcasting

//if(c != null)
//    c.PintarCirculo();
//else
//    Console.WriteLine("Operação de downcasting é inválida");




//Object carroObj = new Carro();
//try
//{
//	var x = (string)carroObj;
//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);
//}
//var x = carroObj as string;

//if (x != null)
//    Console.WriteLine("converteu obj para string");
//else
//    Console.WriteLine("Não foi possível fazer a conversão");
//class Carro { }
