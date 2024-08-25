Console.WriteLine( "## List<T> I e II ##\n");

//Formas de declarar

List<string> lista1;
lista1 = new List<string>();
  
List<int> lista2 = new List<int>();

var lista3 = new List<float>();

List<double> lista4 = new();

List<string> nomes = new()
{
    "Paulo", "Maria", "Bia", "Pedro"
};

var tamanho = nomes.Count;

for (int i = 0; i < nomes.Count; i++)
{
     Console.WriteLine(nomes[i]);
}

//Usa os mesmos métodos dos Arrays, a única diferença é o .Count, que é usado no lugar do Length.