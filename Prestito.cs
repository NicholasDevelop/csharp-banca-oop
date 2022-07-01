namespace csharp_banca_oop
{
    internal class Prestito
    {
        private Cliente intestatario;
        public Cliente Intestatario
        {
            get
            {
                return intestatario;
            }
            set
            {
                this.intestatario = value;
            }
        }


        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                this.amount = value;
            }
        }
        int Rate { get; set; }
        DateTime startDate { get; set; }
        DateTime finishDate { get; set; }

        public Prestito(Cliente intestatario, int amount)
        {
            this.intestatario = intestatario;
            Amount = amount;
        }

        internal void Stampa()
        {
            Console.WriteLine("Nome: " + this.Amount);
        }


    }
}