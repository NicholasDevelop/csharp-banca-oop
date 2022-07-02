namespace csharp_banca_oop
{
    internal class Cliente
    {
        public Cliente(string name, string surname, string fiscalCode)
        {
            Name = name;
            Surname = surname;
            FiscalCode = fiscalCode;
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                this.surname = value;
            }
        }

        private string fiscalCode;
        public string FiscalCode
        {
            get
            {
                return this.fiscalCode;
            }
            set
            {
                this.fiscalCode = value;
            }
        }
        int Salary { get; set; }

        internal void Stampa()
        {
            Console.WriteLine("Nome: " + this.Name);
            Console.WriteLine("Cognome: " + this.Surname);
            Console.WriteLine("Codice fiscale: " + this.fiscalCode);
        }
    }
}