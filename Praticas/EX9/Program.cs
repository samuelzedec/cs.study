using EX9;
Contato contato = new();

void Sms(object? sender, Cliente cliente)
{
    Console.WriteLine($"\nSMS:");
    Console.WriteLine($"\tData: {cliente.DataAtual.ToLongTimeString()}");
    Console.WriteLine($"\tContato: {cliente.Name}");
    Console.WriteLine($"\tTelefone: {cliente.Telefone}");
    Console.WriteLine($"\tMensagem: {cliente.Mensagem}");
};

void Email(object? sender, Cliente cliente)
{
    Console.WriteLine($"\nEMAIL:");
    Console.WriteLine($"\tData: {cliente.DataAtual.ToLongTimeString()}");
    Console.WriteLine($"\tContato: {cliente.Name}");
    Console.WriteLine($"\tEmail: {cliente.Telefone}");
    Console.WriteLine($"\tMensagem: {cliente.Mensagem}");
};
contato.Adicionar(Sms);
contato.Adicionar(Email);
contato.ContatarCliente("Samuel", "samuelzedec@gmail.com", "(92) 98564-0774", DateTime.Now);