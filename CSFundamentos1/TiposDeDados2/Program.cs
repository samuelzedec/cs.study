Console.WriteLine("Atribuindo valores a double, float, decimal");
Console.WriteLine();
double n1 = 1.234;
float n2 = 1.234F;
decimal n3 = 1.2345M;

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.ReadLine();

Console.WriteLine("Comparando a precisão de float, double e decimal");
float x = 1f / 3f; //Nesse caso estou dizendo: 1 Float dividido por 3 FLoat
Console.WriteLine(x);

double y = 1d / 3d;
Console.WriteLine(y);

decimal z = 1m / 3m;
Console.WriteLine(z);