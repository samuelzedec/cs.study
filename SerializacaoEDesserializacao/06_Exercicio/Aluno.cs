using System.Text.Json.Serialization;

namespace _06_Exercicio;

public class Aluno
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    [JsonIgnore]
    public int Age { get; set; }
    
    public Aluno() {}

    public Aluno(int id, string name, string email, int age)
    {
        Id = id;
        Name = name;
        Email = email;
        Age = age;
    }
}