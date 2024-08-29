Console.WriteLine("## hrença - Classe Object ##\n");

Nada nada = new();
Nada nada1 = new();

if (nada.Equals(nada1))
{
    Console.WriteLine(true + " 1");
} else
{
    Console.WriteLine(false);
}

if(nada.GetType() == typeof(Nada))
{
    Console.WriteLine(true + " 2");
}

string nome = "Samuel";
Console.WriteLine(nome.GetHashCode());

public class Nada
{
     
}