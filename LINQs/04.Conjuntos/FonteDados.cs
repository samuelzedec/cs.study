namespace _04.Conjuntos;

public static class FonteDados
{
    public static int[] GetIdades()
        => [30, 33, 35, 36, 40, 30, 33, 30, 40];

    public static string[] GetNomes()
    {
        string[] nomes = ["Paulo", "MARIA", "paulo", "Amanda", "maria", "Amanda"];
        return nomes;
    }

    public static string[] GetPaises1()
    {
        string[] paises = ["Brasil", "USA", "UK", "Argentina", "China"];
        return paises;
    }

    public static string[] GetPaises2()
    {
        string[] paises = ["Brasil", "uk", "Argentina", "França", "Japão"];
        return paises;
    }

    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Maria", Idade = 36 },
            new Aluno() { Nome = "Manoel", Idade = 33 },
            new Aluno() { Nome = "Amanda", Idade = 21 },
            new Aluno() { Nome = "Carlos", Idade = 18 },
            new Aluno() { Nome = "Jaime", Idade = 36 },
            new Aluno() { Nome = "Debora", Idade = 33 },
            new Aluno() { Nome = "Alicia", Idade = 18 },
            new Aluno() { Nome = "Sandra", Idade = 19 },
        };
        return alunos;
    }
    
}