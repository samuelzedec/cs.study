/*Console.WriteLine("Antes de lançar a exception");
throw new Exception("Lançando uma exceção manualmente");
Console.WriteLine("Depois de lançar uma exceção!");*/

try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\nTratando o erro em Main\n");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
Console.ReadKey();

public class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Tratando o erro em Classe A");
            //Esse throw esta chamando novamente a exceção que está a ser lançada no Método ProcessarB 
            throw;
        }
    }
}

public class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Tratando o erro em classe B");
            //Esse throw esta chamando novamente a exceção que está a ser lançada no Método ProcessarC
            throw ex;
            //Esse throw ex, referência o ex do parâmetro, ele é menos utilizado, porque ele apaga a exceção passada.
            //Então a exceção de ProcessarC vai ser esquecida e uma nova exceção daqui para frente surgirá 
        }
    }
}

public class C
{
    public static void ProcessarC() => throw new NotImplementedException("Método não implementado");
}