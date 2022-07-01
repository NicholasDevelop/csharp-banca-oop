namespace csharp_banca_oop
{
    internal class Cliente
    {
        public Cliente(string name)
        {
            Name = name;
        }

        string Name { get; set; }
        string Surname { get; set; }
        string FiscalCode { get; set; }
        int Salary { get; set; }

        internal void Stampa()
        {
            Console.WriteLine("Nome: " + this.Name);
        }
    }
}