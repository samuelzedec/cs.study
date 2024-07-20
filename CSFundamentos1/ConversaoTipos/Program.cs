namespace ConversaoTipos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Conversão de tipos ##\n");

        // int varInt = 5; //int usa 4 bytes
        // double varDouble = varInt; //double usa 8 bytes

        // //byte = 1 byte
        // //short = 2 bytes
        // //int = 4 bytes
        // //long = 8 bytes
        // //float = 4 bytes
        // //double = 8 bytes
        // //decimal = 16 bytes

        // Console.WriteLine(varDouble + "\n");

        // int numeroInt = 2145678;
        // long numeroLong = numeroInt;
        // float numeroFloat = numeroInt;
        // double numeroDouble = numeroInt;
        // decimal numeroDecimal = numeroInt;

        // Console.WriteLine(numeroInt);
        // Console.WriteLine(numeroLong);
        // Console.WriteLine(numeroFloat);
        // Console.WriteLine(numeroDouble);
        // Console.WriteLine(numeroDecimal);

        double varDouble = 12.456; //8 bytes
        Console.WriteLine(varDouble);
        int varInt = (int)varDouble; //4 bytes
        Console.WriteLine(varInt);

        int num1 = 10;
        int num2 = 4;

        float resultado = (float)num1 / num2; 
        //^Aqui estamos dividindo um flaot por um int, e retornadno um float
        Console.WriteLine(resultado);
    }
}