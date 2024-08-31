using _12_Modificadro_Abstract;
Console.WriteLine("## Modificador Abstract I e II ##\n");

// Forma forma = new(); não é possivel criar uma instancia

Quadrado q = new();
Console.WriteLine(q.Descricao());

Console.Write("Informe a cor o quadrado: ");
q.Cor = Console.ReadLine();

Console.Write("\nInforme o valor do lado do quadrado: ");
q.Lado = Convert.ToDouble(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nArea do quadrado: {q.Area} \nPerimetro do quadrado: {q.Perimetro} \nCor do quadrado: {q.Cor}");