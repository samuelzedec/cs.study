using System.Collections;

Console.WriteLine("## ArrayList I, II, III, IV ##\n");

//ArrayList lista;
//lista = new ArrayList();

//ArrayList lista = new ArrayList();

//var lista = new ArrayList();

//ArrayList lista = new() ou new(5);

//ArrayList lista = new() { 4.5d, 5, true, "", null };

//lista.Add(6.4d);
//lista.Insert(0, "marta");

ArrayList lista = new() { "Maria", 5, false };
int[] array1 = { 1, 2, 3 };

lista.AddRange(array1);
lista.InsertRange(0, array1);

foreach (var i in lista)
{
    Console.WriteLine(i);
}

lista.Remove(5);
lista.RemoveAt(0);
lista.RemoveRange(0, 2);
Console.WriteLine();

foreach (var i in lista)
{
    Console.WriteLine(i);
}

//Temos os métodos:
/* 
    .Contains() = Verifica se o elemento existi, se existir, ele retorna true, se n"ao, retornará false.

    .Sort() = Ordene em ordem ascendete o ArrayList.

    .Clear() = Limpará todo o array
 */
