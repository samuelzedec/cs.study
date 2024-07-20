class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Estrutura de repetição com goto/label ##\n");
        int i = 1;

        repetir: //repetir: é o ome atribuido a label para ser chamado pelo goto
            Console.WriteLine($"Valor de i: {i}");
            i++;
        
        if(i <= 10)
            goto repetir;
            //goto: usado para chamar o a função repetir
    }
}