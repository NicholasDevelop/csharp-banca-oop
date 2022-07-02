using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Banca
    {

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

        public List<Cliente> clienti;

        List<Prestito> prestiti;

        public Banca(string name)
        {
            Name = name;
            clienti = new List<Cliente>();
            prestiti = new List<Prestito>();
        }

        public static void StampaTitolo(string titolo, string sottotitolo)
        {
            Console.WriteLine("**** {0} ****", titolo);
            Console.WriteLine();
            Console.WriteLine(sottotitolo);
            Console.WriteLine();
        }


        /* METODI CLIENTE */
        public void NewClient(Cliente cliente)
        {
            clienti.Add(cliente);
        }

        public static Cliente CreateClient()
        {
            Banca.StampaTitolo("Creazione nuovo cliente", "Inserisci il nuovo cliente");

            Console.Write("/tInserisci il nome: ");
            string name = Console.ReadLine();

            Console.Write("/tInserisci il cognome: ");
            string surname = Console.ReadLine();

            Console.Write("/tInserisci il codice fiscale: ");
            string fiscalCode = Console.ReadLine();

            Cliente nuovo = new Cliente(name, surname, fiscalCode);
            return nuovo;
        }
        internal void ClientList()
        {
            Banca.StampaTitolo("Lista Clienti", "");

            int pos = 1;
            foreach (Cliente cliente in clienti)
            {
                Console.WriteLine(pos + ". ");
                cliente.Stampa();
                pos++;
            }
        }

        internal static int ClientRequest()
        {
            Console.Write("/tInserisci il numero dell'utente: ");
            int numClient = int.Parse(Console.ReadLine());

            return numClient;
        }

        internal Cliente GetClient(int indexClient)
        {
            indexClient--;

            if (indexClient < 0 || indexClient >= clienti.Count())
            {
                Console.WriteLine("Error: Il cliente selezionato non esiste!");
                return null;
            }

            return clienti[indexClient];
        }

        internal static void ModifyClient(Cliente client)
        {
            if (client != null)
            {
                Cliente clientChanges = Banca.CreateClient();
                client.Name = clientChanges.Name;
                client.Surname = clientChanges.Surname;
                client.FiscalCode = clientChanges.FiscalCode;
            }
        }

        /* METODI PRESTITO */


        //public static Prestito CreateLoan()
        //{
        //    Banca.StampaTitolo("Creazione nuovo prestito", "Inserisci il nuovo prestito");

        //    Console.Write("/tInserisci il l'ammontare: ");
        //    int amount = int.Parse(Console.ReadLine());

        //    Prestito nuovo = new Prestito(, amount);
        //    return nuovo;
        //}

        public Prestito CreateLoan(Cliente intestatario, float amount, int rate, string startDate, string finishDate)
        {
            return new Prestito(intestatario, amount, rate, startDate, finishDate);
        }

        public void NewLoan(Prestito prestito)
        {
            prestiti.Add(prestito);
        }

        internal void LoanList()
        {
            Banca.StampaTitolo("Lista prestiti", "");

            int pos = 1;
            foreach (Prestito prestito in prestiti)
            {
                Console.WriteLine(pos + ". ");
                prestito.Stampa();
                pos++;
            }
        }

        //internal static Prestito SearchLoan()
        //{
            
        //}
    }
    
}
