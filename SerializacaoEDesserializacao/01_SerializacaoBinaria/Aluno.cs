
namespace _01_SerializacaoBinaria;

[Serializable] //Aqui está dizendo que a classe pode ser serializada
public class Aluno
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; 
    //Ao atribuir um valor na propriedade, seu valor padrão não será mais null
    public string Email { get; set; } = string.Empty;

    [NonSerialized] //Aqui está dizendo que a propriedade não será serializada
    public int Age;

    public Aluno(int id, string name, string email, int age)
    {
        Id = id;
        Name = name;
        Email = email;
        Age = age;
    }
}
