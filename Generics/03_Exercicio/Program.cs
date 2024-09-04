Console.WriteLine("## Exercício ##\n");
Generic<int> classe = new();

for(int i = 0; i < classe.Tamanho; i++)
    classe.Adicionar(i);

for(int j = 0; j < classe.Tamanho; j++)
    Console.WriteLine(classe[j]);


Console.ReadKey();


public class Generic<Type> 
{
    Type[] arr = new Type[10];
    int i = 0;
    public int Tamanho { get { return arr.Length; } }

    public void Adicionar(Type Value)
    {
        if(i < arr.Length) arr[i] = Value;
        i++;
    }

    public Type this[int index]
    {
        get 
        {
            if(index < arr.Length) return arr[index];
            return arr[0];
        }

        set 
        {
            if(index < arr.Length) arr[index] = value;
        }
    }

}
