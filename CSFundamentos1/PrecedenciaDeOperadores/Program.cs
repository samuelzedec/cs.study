class Program 
{
    static void Main(string[] args) 
    {
        Console.WriteLine("## Precedência de operadores ##\n");

        // int x = (10 - 2) * 2 * 3;
        // Console.WriteLine(x);

        // bool b = !(9 != 8) && (5 >= 7 || 8 >= 6);
        // Console.WriteLine(b);

        int a = 5, b = 6, c = 6;
        int r = --a * b - ++c;
        Console.WriteLine(r); 
    }
}