//Console.WriteLine("Testando lógica em target");
//int[] nums = { 2, 11, 7, 15, 19 };

//Console.WriteLine("Array: { 2, 11, 7, 15, 19 }");
//Console.Write("Informe um número: ");
//int num = Convert.ToInt32(Console.ReadLine());
//bool achado = false;

//for(int i = 0; i < nums.Length; i++)
//{
//    for(int j = 0; j < nums.Length; j++)
//    {
//        if (nums[i] + nums[j] == num)
//        {
//            Console.WriteLine($"Indice dos números = [{i}, {j}]");
//            achado = true;
//            break;
//        }
//    }

//    if(achado) break;
//}


string letra1 = "ABC";
string letra2 = "ABABABAAB";

string repetido = "";

for (int i = 0; i < letra1.Length; i++)
{
    for (int j = 0; j < letra2.Length; j++)
    {
        char car = '\0';
        if (letra1[i] == letra2[j])
        {
            car = letra1[i];
            if(!repetido.Contains(car)) {
                repetido += car;
            }
        }
    }
}
Console.WriteLine(repetido);

//string palavra = "arara";
//string inverso = "";

//for(int i = palavra.Length - 1; i >= 0; i--)
//{
//    inverso += palavra[i];
//}

//if(palavra == inverso)
//{
//    Console.WriteLine("É um palídromo");
//}