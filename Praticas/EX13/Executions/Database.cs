using System.Text.Json;
using Entities;
using Message.Global;

namespace Executions.Menu;

public static class Database
{
    private static Library _library = new();
    public static Library Library
    {
        get => _library;
        private set => _library = value;
    }

    private static List<Client> _customers = new();
    public static List<Client> Customers
    {
        get => _customers;
        set => _customers = value;
    }

    private static string _pathDocumentClient =
        @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\Praticas\EX13\FilesForData\SaveCustormerData.json";

    private static string _pathDocumentBooks =
        @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\Praticas\EX13\FilesForData\BooksAvailable.json";

    private static string _pathDocumentInvoicing =
        @"C:\Users\Samuel Zedec\OneDrive\Documentos\cs.study\Praticas\EX13\FilesForData\TotalRevenue.json";

    public static async Task ReturnDataFromTheDatabaseAsync()
    {
        using var fileStreamClient = new FileStream(
            _pathDocumentClient, 
            FileMode.Open, 
            FileAccess.Read
        );
        var dataClients = await JsonSerializer.DeserializeAsync<List<Client>>(fileStreamClient);
        
        using var fileStreamBook = new FileStream(
            _pathDocumentBooks, 
            FileMode.Open, 
            FileAccess.Read
        );
        var dataBooks = await JsonSerializer.DeserializeAsync<List<Book>>(fileStreamBook);
        
        using var fileStreamInvoicing = new FileStream(
            _pathDocumentInvoicing, 
            FileMode.Open, 
            FileAccess.Read
        );
        var dataInvoicing = await JsonSerializer.DeserializeAsync<Invoicing>(fileStreamInvoicing);

        _customers = dataClients ?? new List<Client>();
        _library.Books = dataBooks ?? new List<Book>();
        _library.TotalRevenue = dataInvoicing ??  new Invoicing();
    }

    public static void SalveData()
    {
        Console.Clear();
        Console.WriteLine("Salvando alterações. Só um momento...");
        using (FileStream stream = new(_pathDocumentClient, FileMode.Create))
        {
            JsonSerializer.Serialize(stream, _customers);
        }
        
        using (FileStream stream = new(_pathDocumentBooks, FileMode.Create))
        {
            JsonSerializer.Serialize(stream, _library.Books);
        }
        
        using (FileStream stream = new(_pathDocumentInvoicing, FileMode.Create))
        {
            JsonSerializer.Serialize(stream, _library.TotalRevenue);
        }
        
        GlobalMessages.Continue();
    }
}