using _01_Delegates;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("## SingleCast Delegate ##\n");
        var resultado = Calculadora.Somar(10, 50);
        Console.WriteLine(resultado);
        
        //Forma de criar um delegate e liga-ló a um método
        DelegateCalculadora calc = new(Calculadora.Somar);
        /*
         * Poderiamos fazer assim também (mais usado):
         *      DelegateCalculadora calc = Calculadora.Somar;
         *
         * Podemos também usar a expressão lambda:
         *      DelegateCalculadora calc = (float x, float y) => Calculadora.Somar(x, y);
         */
        
        //Forma de chamar o delegate
        var resultado1 = calc.Invoke(20, 30); 
        //var resultado = calc(20, 30);
        Console.WriteLine($"Soma = {resultado1}");

        //Alterando o método do delegate
        calc = Calculadora.Dividir;
        var resultado2 = calc(90, 10);
        Console.WriteLine($"Divisão: {resultado2}");
        
        calc = Calculadora.Subtrair;
        var resultado3 = calc(90, 10);
        Console.WriteLine($"Subtrair: {resultado3}");
        
        calc = Calculadora.Multiplicar;
        var resultado4 = calc(90, 10);
        Console.WriteLine($"Multiplicar: {resultado4}");
        
        Console.ReadKey();
    }
}


//Os delegates tem que ser declarado fora do método main
//Lembrando que eles são tipo por referência
public delegate float DelegateCalculadora(float x, float y);
/*
 * public: modificador do delegate
 * delegate: palavra chave para criar um delegate
 * float: delegates precisam de retorno
 * (): os delegates precisam de parâmetro
 *
 * Vale ressaltar que os delgates que está com o retorno e os parâmetros idênticos ao do método que irá criar sua assinatura
 */