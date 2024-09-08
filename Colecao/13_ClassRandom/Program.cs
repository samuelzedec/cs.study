Console.WriteLine("## Class Random ##\n");

Random random = new();

//Console.WriteLine(random.Next());
//Console.WriteLine(random.Next(20));
//Console.WriteLine(random.Next(0, 20));
//Console.WriteLine(random.NextDouble());

//byte[] randBytas = new byte[10];
//random.NextBytes(randBytas);

//foreach(var bit  in randBytas)
//{
//    Console.WriteLine(bit);
//}

int[] numeroSorteado = new int[6];

for (int i = 0; i < numeroSorteado.Length; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random.Next(1, 61);
    } while(numeroSorteado.Contains(numeroAleatorio));
    
    numeroSorteado[i] = numeroAleatorio;
    Console.WriteLine(numeroAleatorio);
} 