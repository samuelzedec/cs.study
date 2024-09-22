Console.WriteLine("## Delegate Func ##\n");

/*
 * Anotações sobre Delegate Func:
 * 
 * O primeiro Tipo é o tipo do parâmetro e o último é o valor do retorno.
 * Uma func pode ter so um tipo, o que quer dizer apenas o tipo do retorno.
 * Supondo q temos 5 tipos, os 4 primeiros serão de parâmetro e o 5º será o tipo do retorno.
 */

Console.Write("Informe um número double: ");
var num = Convert.ToDouble(Console.ReadLine());

/*
 * Usando método anônimo numa Func
    Func<double, double> raiz = delegate(double value) 
    { 
        return Math.Sqrt(value);
    };
*/

Func<double, double> raiz = (double value) => Math.Sqrt(value);
var result = raiz(num);
Console.WriteLine($"Raiz do número: {result}");