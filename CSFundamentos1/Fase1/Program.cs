namespace Fase1;

class Program
{
    static void Main(string[] args)
    {
        //1º Questão
        int idade = 35;
        Console.WriteLine(idade);

        //2º Questão
        string nome = "Maria";
        Console.WriteLine(nome);

        //3º Questão
        double altura = 3.45;
        Console.WriteLine(altura);

        //4º Questão
        DateTime data = new DateTime(1999, 09, 04);
        Console.WriteLine(data);

        //5º Questão
        const int ano = 12;
        Console.WriteLine(ano);

        //6º Questão
        double? nota = 7.80;
        Console.WriteLine(nota ?? 0);
        
        //14º Questão
        int x = 77;
        int y = 66;
        Console.WriteLine($"A soma de x e y é: {x + y}");

        //15º Questão
        // (F) double 1valor = 12.45;
        // (F) string #nome = "Pedro";
        // (V) float _temperatura = 12.45f;
        // (F) double int = 5;
        // (F) decimal renda extra = 91.45m;
        // (F) bool status$conta = false;
        // (V) string titulo3 = “Tópico 1”;
        // (V) float salario_mensal = 1999.55f;
        // (V) int percentualValorDesconto = 5;
        // (V) const bool MENSALIDADE_EM_DIA = true;
    }
}
