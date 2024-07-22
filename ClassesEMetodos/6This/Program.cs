Console.WriteLine("## this ##\n");

Teste test = new(88, 99);

// public class Cliente
// {
//     public string? Nome;
//     public int Idade;

//     public Cliente(string? Nome, int Idade) {
//         this.Nome = Nome;
//         this.Idade = Idade;
//     }
// }

// --------------------------------------

// public class Teste
// {
//     public int Num1;
//     public int Num2;

//     public void Passar(Teste t) {
//         //Como passamos this com parâmetro, o t tem acesso as propriedades Num1 e Num2
//         Console.WriteLine($"\nthis = {this}");
//         Console.WriteLine($"Num1: {t.Num1}");
//         Console.WriteLine($"Num2: {t.Num2}");
//     }

//     public void Exibir() {
//         //passando this como um parâmetro (a classe Teste)
//         Passar(this);
//     }
// }

//----------------------------------------

public class Teste
{
    public Teste(int num1, int num2) {
        Console.WriteLine($"Num1 = {num1} | Num2 = {num2}");
    }

    public Teste(int num3) : this(888, 777) {
        Console.WriteLine($"Num3 = {num3}");
    }
}

