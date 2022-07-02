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


        private float amount;
        public float Amount
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
        private int rate;
        public int Rate
        {
            get
            {
                return rate;
            }
            set
            {
                this.rate = value;
            }
        }
        private DateTime startDate;
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                this.startDate = value;
            }
        }
        private DateTime finishDate;
        public DateTime FinishDate
        {
            get
            {
                return finishDate;
            }
            set
            {
                this.finishDate = value;
            }
        }

        public Prestito(Cliente intestatario, int amount, int Rate, DateTime startDate, DateTime finishDate)
        {
            this.intestatario = intestatario;
            this.Amount = amount;
            this.Rate = Rate;
            this.startDate = startDate;
            this.finishDate = finishDate;
        }

        internal void Stampa()
        {
            Console.WriteLine("Nome: " + this.Amount);
        }


    }
}