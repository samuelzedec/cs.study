Console.WriteLine("## Bloco Try-Catch-Finally ##\n");

try
{
    Console.Write("Informe o dividendo: ");
    var dividendo = Convert.ToInt32(Console.ReadLine()); //OverFlowException

    Console.Write("\nInforme o divisor: ");
    var divisor = Convert.ToInt32(Console.ReadLine());

    var resultado = dividendo / divisor;
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}"); //FormatException
    //DivideByZeroException
}
catch (FormatException)
{
    /*
     * FormatException:
     
     * A exceção FormatException em C# é lançada quando um método tenta converter uma string para um tipo de valor,
     * e a string não está no formato adequado para essa conversão. 
     */
    Console.WriteLine("$\nInforme um valor inteiro");
}
catch (OverflowException)
{
    /*
     * OverflowException:
     
     * A exceção OverflowException em C# é lançada quando uma operação resulta em um valor que está fora do
     * intervalo permitido para o tipo de dado. Isso geralmente acontece em operações aritméticas ou conversões de
     * tipos que resultam em valores maiores ou menores do que o tipo de dados pode suportar.
     */
    Console.WriteLine("\nInforme um valor inteiro entre 1 e 999999");
}
catch (DivideByZeroException)
{
    /*
     * DivideByZeroException:
    
     * A exceção DivideByZeroException em C# é lançada quando ocorre uma tentativa de divisão por zero em uma
     * operação aritmética. Isso é especialmente relevante em operações de divisão onde o divisor é zero, o que é
     * matematicamente indefinido e, portanto, resulta em um erro.
     */
    Console.WriteLine("\nInforme um divisor diferente de 0");
}
catch (Exception ex)
{
    /*
     * Exception:
    
     * A classe Exception é a classe base para todas as exceções em C# e é usada para representar erros que ocorrem
     * durante a execução de um programa. Quando você cria uma nova exceção, geralmente você usa uma classe derivada
     * de Exception, como DivideByZeroException ou FormatException, que são subclasses de Exception.
     */
    Console.WriteLine(ex.Message);
} 