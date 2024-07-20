class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Operadores Relacionais ##\n");

        int x = 10;
        int y = 20;


        bool igual = x == y;
        bool diferente = x != y;
        bool maiorOuIgual = x >= y;
        bool menorOuIgual = x <= y;

        //Podemos fazer assim ou colocar direto na na interpolação

        Console.WriteLine($"Valor de X = {x} | Valor de Y = {y}\n");
        
        Console.WriteLine($"Igual: {igual}");
        Console.WriteLine($"Diferente: {diferente}");
        Console.WriteLine($"Maior ou Igual: {maiorOuIgual}");
        Console.WriteLine($"Menor ou Igual: {menorOuIgual}\n");

        string a = "Curso";
        string b = "curso";

        Console.WriteLine($"Valor de A = {a} | Valor de B = {b}\n");
        Console.WriteLine($"Igual: {a.Equals(b)}"); //a == b

    }
}