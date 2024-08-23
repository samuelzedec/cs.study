Console.WriteLine("Arrays I, II, III");

int[] num;
num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//string[] nome = new string[5] {"Ana", "Maria", "Marta", "Paulo", "Carlos"};

//string[] nome1 = new string[] { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

string[] nome = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

Console.WriteLine($"nome no indice 2: {nome[2]}");

//declarando um array
int[] num1;
num1 = new int[3];

num1[0] = 1;
num1[1] = 2;
num1[2] = 3;

for(int i = 0; i < num1.Length; i++)
{
    Console.WriteLine(num1[i]);
}

foreach(int number in num1)
{
    Console.WriteLine(number);
}

Console.ReadKey();