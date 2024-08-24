Console.WriteLine("## Arrays Multidimensionais I e II ##\n");

//int[,] num = new int[3, 3]
//{
//    { 1, 2, 3 },
//    { 4, 5, 6 },
//    { 7, 8, 9 }
//};

int[,] num =
{
    { 1 ,2, 3 },
    { 4, 5, 6 }, 
    { 7, 8, 9 }
};

Console.WriteLine($"Elemento no indice [2, 0]: {num[2, 0]}\n");

Console.WriteLine("Array completo: ");


for(int i = 0; i < num.GetLength(0);  i++)
{
    for(int j = 0; j < num.GetLength(1); j++)
    {
        Console.Write(num[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
foreach(int n in num)
{
    Console.WriteLine(n);
}