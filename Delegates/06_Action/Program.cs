Console.WriteLine("## Delegate Action ##\n");

/*
 * Usando método anônimo
    Action<int> dobrar = delegate(int num)
    {
        int resultado = num * 2;
        Console.WriteLine($"Valor dobrado: {resultado}");
    };
*/

//Usando expresão lambda
Action<int> dobrar = (int valor) => Console.WriteLine($"Valor dobrado: {valor * 2}");

//Chamando o delegate Action
Console.Write("Informe um número inteiro: ");
var num = Convert.ToInt32(Console.ReadLine());
dobrar(num);
