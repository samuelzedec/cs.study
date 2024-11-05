using CustomExceptions;
using Entities;
using Messages.Library;
namespace Executions.Menu.BookActions;

public static partial class BookMenu
{
        private static void SeeAllBooks()
    {
        if (Database.Library.Books.Count == 0) throw new EmptyQueueException("Não há livros cadastrados no momento!!");
        foreach (var book in Database.Library.Books)
        {
            LibraryMessages.AllBooks(book);
        }
    }
    
    private static void RegisterBook()
    {
        LibraryMessages.RegisterBook();
        string name = Console.ReadLine() ?? "";
        name = ValidateInput(name, "Nome do livro não pode ser vazio.");

        Console.Write("\nInforme o gênero do livro: ");
        string gender = Console.ReadLine() ?? "";
        gender = ValidateInput(gender, "Gênero não pode ser vazio.");

        DateTime releaseDate = GetReleaseDate();
        decimal price = GetPrice();

        Console.Write("\nInforme o nome do autor: ");
        string authorName = Console.ReadLine() ?? "";
        authorName = ValidateInput(authorName, "Nome do autor não pode ser vazio.");

        Console.Write("\nInforme a biografia breve do autor: ");
        string briefBiography = Console.ReadLine() ?? "";
        briefBiography = ValidateInput(briefBiography, "Biografia do autor não pode ser vazia.");

        Author author = new Author(authorName, briefBiography);
        Book book = new Book(name, gender, releaseDate, price, author);

        Database.Library.Books.Add(book);
        LibraryMessages.RegistrationCompletedSuccessfully(book);
    }

    private static string ValidateInput(string data, string errorMessage)
    {
        while (string.IsNullOrWhiteSpace(data))
        {
            LibraryMessages.InvalidData(errorMessage);
            data = Console.ReadLine() ?? "";
        }
        return data;
    } 
    
    private static DateTime GetReleaseDate()
    {
        DateTime releaseDate;
        while (true)
        {
            Console.Write("\nInforme a data de lançamento do livro (formato: DD/MM/YYYY): ");

            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out releaseDate)) break;
            
            LibraryMessages.InvalidDate();
        }
        Console.ResetColor();
        return releaseDate;
    }

    private static decimal GetPrice()
    {
        decimal price;
        while (true)
        {
            Console.Write("\nInforme o preço do livro: ");
            string priceInput = Console.ReadLine() ?? "";

            if (decimal.TryParse(priceInput, out price) && price >= 0) break; 
            LibraryMessages.InvalidPrice();
        }
        Console.ResetColor();
        return price;
    }
    
    
}