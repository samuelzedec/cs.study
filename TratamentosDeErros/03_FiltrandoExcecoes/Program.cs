int dividendo;
int divisor = 0;
try
{
    Console.Write("Informe o dividendo: ");
    dividendo = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nInforme o divisor: ");
    divisor = Convert.ToInt32(Console.ReadLine());

    var resultado = dividendo / divisor;
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");
}
//DateTime.Now.DayOfWeek = Quer dizer que irá transformar a data atual em um dia da semana
//DayOfWeek.Friday = Isso se refere a um dia da semana, no caso Sexta-Feira
catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
{
    Console.WriteLine(
        "\nHoje é sexta-feira e não capturamos estas \nexceções por motivos óbvios... \n\nSextouuuuu\n\n");
}
catch(Exception) when(divisor == 0)
{
    Console.WriteLine("Está linha nunca será lida!");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("Filtro de exceção com format");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}