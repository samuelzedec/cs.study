using System.Net.Mail;
using System.Threading.Channels;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("## Exercise ##\n");
        Dictionary<int, Student> School = new()
        {
            { 1, new Student("Maria", 7) },
            { 2, new Student("Eric", 8) },
            { 3, new Student("Ana", 9) },
            { 4, new Student("Alex", 6) },
            { 5, new Student("Diná", 5)}
        };

        Console.WriteLine("Exibir os valores:\n");
        foreach (var student in School) Console.WriteLine($"ID: {student.Key} | Name: {student.Value?.Name} | Nota: {student.Value?.Average}");

        Console.ReadKey();
        Console.Clear();

        Console.Write("Informe o ID do aluno: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (School.ContainsKey(id))
        {
            Console.Write($"Informe a nova nota do aluno {School[id].Name}: ");
            var note = Convert.ToDouble(Console.ReadLine());

            School[id].Average = note;

            Console.WriteLine($"Nome: {School[id].Name} | Nota: {School[id].Average}");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado");
        }

        Console.ReadKey();
        Console.Clear();

        Console.Write("Informe o ID do aluno: ");
        int idRemove = Convert.ToInt32(Console.ReadLine());

        var removed = School.Remove(idRemove);

        if(removed) Console.WriteLine("Aluno removido!");
        else Console.WriteLine("Aluno não removido");

        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Adiconando aluno!\n");
        var newID = 6;
        School.Add(newID, new Student("Vilma", 7));

        Console.WriteLine($"Novo aluno: {School[newID].Name} | Nota: {School[newID].Average}");

        Console.ReadKey();
        Console.Clear();

        var School2 = School.OrderBy(x => x.Value.Name);

        foreach (var student in School2)
        {
            Console.WriteLine($"{student.Key} | {student.Value.Name} | {student.Value.Average}");
        }
    }
}


public class Student
{
    private readonly string name;
    public string Name
    {
        get { return name; }
    }

    private double average;
    public double Average
    {
        get { return average; }
        set { average = value; }
    }

    public Student(string name, int average)
    {
        this.name = name;
        this.average = average;
    }

}