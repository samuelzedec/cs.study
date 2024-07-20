namespace ConversaoTipos2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Conversão de tipos ##\n");

        // int valor = 123;
        // double valorDouble = 12.45;
        // decimal valorDecimal = 12.45678M;

        // string s1 = valor.ToString();
        // string s2 = valorDouble.ToString();
        // string s3 = valorDecimal.ToString();

        // Console.WriteLine(s1);
        // Console.WriteLine(s2);
        // Console.WriteLine(s3);

        int valorInt = 10;

        double valorDouble = 5.35;
        bool valorBool = true;
        string okok = Convert.ToString(valorDouble);
        Console.WriteLine(okok);

        Console.WriteLine(Convert.ToString(valorInt));
        Console.WriteLine(Convert.ToDouble(valorInt));
        Console.WriteLine(Convert.ToString(valorBool));
        Console.WriteLine(Convert.ToInt32(valorDouble));
        Console.WriteLine(Convert.ToString(valorDouble));
        
        // int varInt = 100000;
        // Console.WriteLine(Convert.ToByte(varInt));
    }
}