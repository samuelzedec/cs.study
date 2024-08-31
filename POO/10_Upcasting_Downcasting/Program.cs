using _10_Upcasting_Downcasting;
Console.WriteLine("## Upcasting e Downcasting ##\n");

//Upcasting 
/*Forma circulo = new Circulo(10, 20);
//Circulo circulo = new Circulo(10, 20);
//Forma forma = circulo;
//forma.Desenhar();
//Console.WriteLine(forma == circulo);
*/

//Downcasting
Circulo circulo = new Circulo(20, 20);
Forma f = circulo;

Circulo c = (Circulo)f;
c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == f);
Console.WriteLine(c == circulo);
