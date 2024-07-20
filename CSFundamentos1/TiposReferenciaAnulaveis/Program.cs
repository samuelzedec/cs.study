class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Tipos de Referêncai Anuláveis ##\n");

        string? nome = "Samuel";
        //string nome = "";
        Console.WriteLine(nome?.ToUpper());

        Console.ReadKey();
    }
}