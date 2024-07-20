using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        //Questão 1
        // string nome = "Paulo";
        // int idade = 19;
        // double nota = 7.5;

        // Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
        // Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

        //-------------------------------------------------------------

        //Questão 2
        // Console.WriteLine($"Aluno {nome} \ntem {idade} anos \ne nota {nota}");

        //-------------------------------------------------------------

        //Questão 3
        //float => 
        //( ) int
        //(x) double
        //( ) long
        //( ) decimal

        //-------------------------------------------------------------

        //Questão 4
        // ( ) int para long
        // (x) double para long
        // (x) double para float
        // (x) decimal para float
        // (x) long para int
        // (x) double para decimal

        //-------------------------------------------------------------

        //Questão 5
        // char letra1, letra2, letra3;
        // Console.Write("Informe a letra 1: ");
        // letra1 = Convert.ToChar(Console.ReadLine());

        // Console.Write("Informe a letra 2: ");
        // letra2 = Convert.ToChar(Console.ReadLine());

        // Console.Write("Informe a letra 3: ");
        // letra3 = Convert.ToChar(Console.ReadLine());

        // Console.WriteLine($"1º - {letra3} \n2º - {letra2} \n3º - {letra1}");

        //-------------------------------------------------------------

        //QUestão 14
        // (F) long resultado = 1.32;
        // (V) var nome = “Maria”;
        // (V) string resultado = 100.ToString();
        // (V) A sequência de escape \n inclui uma nova linha
        // (F) float f = 5.45;
        // (V) decimal valor = (decimal) 10.99f;
        // (F) var status = null;
        // (V) object o = 12.45m;
        // (V) string titulo = true.ToString();
        // (V) A sequencia \t inclui uma tabulação vertical

        //-------------------------------------------------------------

        //Questão 7
        // double n1, n2;
        // Console.Write("Informe o primeiro número: ");
        // n1 = Convert.ToDouble(Console.ReadLine());

        // Console.Write("Informe o segundo número: ");
        // n2 = Convert.ToDouble(Console.ReadLine());
        
        // Console.WriteLine($"Soma: {n1} + {n2} = {n1 + n2}");
        // Console.WriteLine($"Subtração: {n1} - {n2} = {n1 - n2}");
        // Console.WriteLine($"Multiplição: {n1} * {n2} = {n1 * n2}");
        // Console.WriteLine($"Exponenciação: {n1} elevado a {n2} = {Math.Pow(n1, n2)}");
        // Console.WriteLine($"Divisão: {n1} / {n2} = {n1 / n2}");
        // Console.WriteLine($"Módulo: {n1} % {n2} = {n1 % n2}");

        //-------------------------------------------------------------

        //Questão 8
        // int a, b, c;
        // Console.Write("Informe o valor de A: ");
        // a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Informe o valor de B: ");
        // b = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Informe o valor de C: ");
        // c = Convert.ToInt32(Console.ReadLine());

        // int delta = (int)(Math.Pow(b, 2) - 4 * a * c);
        // int raiz = (int)Math.Sqrt(delta);

        // int x1 = Convert.ToInt32((-b + raiz) / (2 * a));
        // int x2 = Convert.ToInt32((-b - raiz) / (2 * a));

        // Console.WriteLine($"X1 = {x1} | X2 = {x2}");

        //-------------------------------------------------------------

        //Questão 9
        // Console.Write("Informe seu nome: ");
        // string? nome = Console.ReadLine();

        // Console.Write("Informe sua senha: ");
        // int senha = Convert.ToInt32(Console.ReadLine());

        // string validar = (nome == "admin" || nome == "maria") && (senha == 123) ? "Login feito com sucesso" : "Login Inválido";

        // Console.WriteLine(validar);

        //-------------------------------------------------------------

        //Questão 10
        // (V) string? nome; é um exemplo de nullable reference type;
        // (F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
        // (F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
        // (V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
        // (F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
        // (F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
        // (V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
        // (F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
        // (F) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
        // (V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
        // (V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"

        //-------------------------------------------------------------

        //Questão 11
        // int x, y;
        // Console.Write("Informe o valor de X: ");
        // x = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Informe o valor de Y: ");
        // y = Convert.ToInt32(Console.ReadLine());

        // string valorDeX = x % 2 == 0 ? "X é um número par" : "X não é um número par";
        // string valorDeY = y % 2 == 0 ? "Y é um número par" : "Y não é um número par";

        // Console.WriteLine(valorDeX);
        // Console.WriteLine(valorDeY);

        //-------------------------------------------------------------

        //Questão 12
        // Console.Write("Informe um número: ");
        // int x = Convert.ToInt32(Console.ReadLine());
        // int a = 3, b = x, c = 10; 

        // double delta = Math.Pow(b, 2) - 4 * a * c;

        // double x1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
        // double x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);

        // Console.WriteLine($"-6 + x * 5 = {-6 + x * 5}");
        // Console.WriteLine($"(13-2) * x = {(13-2) * x}");
        // Console.WriteLine($"(x + -2) * (20 / x) = {(x + -2) * (20 / x)}");
        // Console.WriteLine($"3x² + x + 10: X1 = {x1} | X = {x2}");
        // Console.WriteLine($"pi * x² = {Math.PI * Math.Pow(x, 2)}");

        //-------------------------------------------------------------

        //Questão 13
        //y = 5 + 6 + 7  = 18

        //-------------------------------------------------------------

        //Questão 14
        // Console.Write("Informe a temperatura em Celsius: ");
        // double c = Convert.ToDouble(Console.ReadLine());

        // double k = c + 273;
        // double f = c * 1.8 + 32;

        // Console.WriteLine($"temperatura em Kelvin: {k}");
        // Console.WriteLine($"temperatura em Farhenheit: {f}");

        //-------------------------------------------------------------

        //Questão 15
        // var numero = 5; 
        // Console.WriteLine(numero++); 
        // numero = 1; 
        // Console.WriteLine(++numero); 
        // numero = 2; 
        // Console.WriteLine(numero--); 
        // numero = 3; 
        // Console.WriteLine(--numero);

    }
}

