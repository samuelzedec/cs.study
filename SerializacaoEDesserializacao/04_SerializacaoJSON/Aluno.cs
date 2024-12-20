﻿using System.Text.Json.Serialization;
namespace _04_SerializacaoJSON;
public class Aluno
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; 
    public string Email { get; set; } = string.Empty;
    //Usamos o JsonIgnore para proibir que uma propriedade seja esterializada
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
