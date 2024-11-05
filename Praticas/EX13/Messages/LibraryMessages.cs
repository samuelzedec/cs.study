using Entities;
using Message.Global;

namespace Messages.Library;

public static class LibraryMessages
{
    public static void ValidateName()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Para acessar é necessário informar a senha da biblioteca!\u001b[0m");
        Console.Write("Digite a senha: ");
    }

    public static void MenuMessages(string name)
    {
        Console.Clear();
        Console.WriteLine($"Olá, bem-vindo ao menu da {name}!" +
                          $"\n[1] - Ver informações da biblioteca" +
                          $"\n[2] - Atender cliente da fila de espera" +
                          $"\n[3] - Ver faturamento" +
                          $"\n[4] - Acessar menu de livros" +
                          $"\n[5] - Voltar ao menu inicial");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(">\u001b[0m ");
    }

    public static void Information(string name, string email, int password, int stock)
    {
        Console.Clear();
        Console.WriteLine("\u001b[1mInformações básicas:\u001b[0m");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Nome: {name}" +
                          $"\nEmail: {email}" +
                          $"\nSenha: {password}" +
                          $"\nLivros cadastrados: {stock}");
        Console.ResetColor();
        GlobalMessages.Continue();
    }

    public static void PurchaseData(string name, string email, List<Book> books, decimal total)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Informações do comprador: \u001b[0m");
        Console.WriteLine($"Nome: {name}" +
                          $"\nEmail: {email}" +
                          $"\nLivros escolhidos:");
        foreach (var book in books)
        {
            Console.WriteLine($"\t-{book} - {book.Price:C2}");
        }

        Console.WriteLine($"Total: \u001b[31m{total:C2}\u001b[0m");
        GlobalMessages.Continue();
    }

    public static void BookMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Menu para o livros: \u001b[0m" +
                          "\n[1] - Ver livros cadatrados" +
                          "\n[2] - Cadastrar novo livro" +
                          "\n[3] - Editar informações de um livro" +
                          "\n[4] - Excluir livro" +
                          "\n[5] - Voltar ao menu anterior");
        Console.Write("\u001b[31m> \u001b[0m");
    }
    
    public static void RegisterBook()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Cadastrando novo livro: \u001b[0m");
        Console.Write("Informe o nome do livro: ");
    }

    public static void AllBooks(Book book)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Informações sobre o livro: \u001b[0m");
        Console.WriteLine($"Nome: {book.Name}" +
                          $"\nGênero: {book.Gender}" +
                          $"\nData de lançamento: {book.ReleaseDate.ToShortDateString()}" +
                          $"\nPreço: {book.Price:C}" +
                          $"\nInformações do author:" +
                          $"\n\t- Nome: {book.Author.Name}" +
                          $"\n\t- Bibliografia: {book.Author.BriefBiography}");
        GlobalMessages.Continue();
    }

    public static void RegistrationCompletedSuccessfully(Book book)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Livro '{book.Name}' registrado com sucesso!");
        Console.ResetColor();
        GlobalMessages.Continue();
    }

    public static void InvalidDate()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Data inválida. Tente novamente.");
    }

    public static void InvalidPrice()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Preço inválido. Tente novamente.");
    }

    public static void InvalidData(string messase)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(messase);
        Console.Write($"\nInforme novamente: \u001b[0m");
    }
}