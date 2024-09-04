Console.WriteLine("## Generics I e II##\n");
// Teste teste = new();
Teste<int, float> teste = new();

int i1 = 10;
float f2 = 10;

teste.Comparar(i1, f2);
// teste.Comparar(f1, f2);
// teste.Comparar(s1, s2);

Console.ReadKey();

// public class Teste
// {
//     public void Comparar<T1, T2>(T1 p1, T2 p2) 
//     {
//         Console.WriteLine($"\nOs tipos: {p1.GetType()} e {p2.GetType()}");
//         var resultado = p1.Equals(p2);
//         Console.WriteLine($"{p1} e {p2} são iguais: {resultado}");
//     }
// }
public class Teste<T1, T2>
{
    public void Comparar(T1 p1, T2 p2)
    {
        Console.WriteLine($"\nOs tipos: {p1?.GetType()} e {p2?.GetType()}");
        var resultado = p1?.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais: {resultado}");
    }
}