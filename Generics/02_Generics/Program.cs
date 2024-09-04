Console.WriteLine("## Generics III ##\n");
ClasseGenerica<int> intObj = new();

//Adicionando valores inteiros na coleção
intObj.Adicionar(10);
intObj.Adicionar(20);
intObj.Adicionar(30);
intObj.Adicionar(40);
intObj.Adicionar(50);

Console.WriteLine("Classse ClasseGeneerica<M> de objetos int");
//Exibindo valores
for(int i = 0; i < intObj.Contador; i++)
    Console.WriteLine(intObj[i]);


public class ClasseGenerica<T> 
{
    //Definição do array com 5 elementos
    T[] obj = new T[5];
    int contador = 0;
    public int Contador { get { return contador; } } 
    //Adicionar Elementos
    public void Adicionar(T item) 
    {
        if(contador < 5) obj[contador] = item;
        contador++;
    }

    //Indexadores para a itereção da instrução foreach
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}
