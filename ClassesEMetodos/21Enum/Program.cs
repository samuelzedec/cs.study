using _21Enum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Tipo Enum ##\n");

        //int segunda = (int)TipoEnum.Segunda;
        //(int): isso se chama cast (conversão forçada)

        //Console.WriteLine(TipoEnum.Segunda);
        //Console.WriteLine($"Valor de TipoEnum.Segunda: {segunda}");
        //Console.WriteLine();

        Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
        Console.WriteLine($"{Categorias.Automativo} - {(int)Categorias.Automativo}");
        Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
        Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
        Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
        Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

        Console.Write($"\nSelecione a Categoria teclando o seu valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        var nomeMembroEnum = (Categorias)valor;
        Console.WriteLine($"\nVocê Selecionou a categoria: {nomeMembroEnum}");
    }
}

