namespace _20Struct
{
    public struct Cliente
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(string? Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        
    }
}

