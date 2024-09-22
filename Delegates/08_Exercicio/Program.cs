Console.WriteLine("## Exercício para praticar Delegates ##\n");
List<Person> list = new()
{
    new Person("João", 20),
    new Person("Maria", 18),
    new Person("Pedro", 25),
    new Person("Carlos", 15),
    new Person("Ana", 17)
}; 

//Método usado para imprimir os nomes e idades na lista
Action<List<Person>> view = delegate(List<Person> persons)
{
    foreach (var person in persons) Console.WriteLine($"Nome: {person.Name} - Idade: {person.Age}");
};

//Método irá ser usado para ser um função de callback do filter
Predicate<Person> filter = (Person person) => person.Age > 18;

//Método irá pegar a pessoa que tiver a maior idade
Func<List<Person>, Person> search = (List<Person> persons) =>
{
    Person older = new("name", 0);
    foreach (var person in persons)
    {
        if (person.Age > older.Age) older = person;
    }
    return older;
};

//Chamando o delgate view
Console.WriteLine("Vendo todos os integrantes da lista:");
view(list);

//Executando o delegate filter
var persons = list.FindAll(filter);
Console.WriteLine("\nVendo os integrantes que tem mais de 18: ");
view(persons);

//Executando o delegate search
var person = search(list);
Console.WriteLine("\nPessoa mais velha do grupo:");
Console.WriteLine($"Nome: {person.Name} - Idade: {person.Age}");

Console.ReadKey();

public class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
}