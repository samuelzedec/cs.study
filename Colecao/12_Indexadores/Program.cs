Console.WriteLine("## Indexadores ##\n");

Time time = new();

time[9] = "10";
time[100] = "90";
time[1] = "4";

Console.WriteLine(time[9]);
Console.WriteLine(time[100]);
Console.WriteLine(time[1]);


 public class Time
{
    private string[] valor = new string[10];

    public string this[int i]
    {
        get
        {
            if(i >= 0 && i < valor.Length)
            {
                return valor[i];
            }

            return "Erro";
        }

        set
        {
            if(i >= 0 && i < valor.Length)
            {
                valor[i] = value;
            }
        }
    }
}
