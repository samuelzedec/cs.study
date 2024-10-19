﻿namespace _02_SerializacaoXML;

public class Aluno
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; 
    public string Email { get; set; } = string.Empty;
    public int Age;
    
    public Aluno() {}

    public Aluno(int id, string name, string email, int age)
    {
        Id = id;
        Name = name;
        Email = email;
        Age = age;
    }
}
