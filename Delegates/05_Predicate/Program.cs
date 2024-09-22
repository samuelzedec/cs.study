Console.WriteLine("## Delegate Predicate ##\n");

Predicate<int> delegatePredicate = (int valor) => valor % 2 == 0;

/*
 * Usando a sintaxe de um método anônimo:
 * Predicate<int> delegatePredicate = delegate(int valor) {return valor % 2 == 0;}
 */

Console.Write("Informe um número inteiro: ");
var num = Convert.ToInt32(Console.ReadLine());

if(delegatePredicate(num)) Console.WriteLine($"O número {num} é par");
else Console.WriteLine($"O número {num} é ímpar");

Console.ReadKey();