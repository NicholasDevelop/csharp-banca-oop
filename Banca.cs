using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Banca
    {
        string Name { get; set; }
        List<Cliente> clienti;

        List<Prestito> prestiti;

        public Banca(string name)
        {
            Name = name;
            clienti = new List<Cliente>();
            prestiti = new List<Prestito>();
        }

        public void NewClient(Cliente cliente)
        {
            clienti.Add(cliente);
        }

        public static Cliente CreateClient()
        {
            Banca.StampaTitolo("Creazione nuovo cliente", "Inserisci il nuovo cliente");

            Console.Write("/tInserisci il nome: ");
            string name = Console.ReadLine();

            Cliente nuovo = new Cliente(name);
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

        public static void StampaTitolo(string titolo, string sottotitolo)
        {
            Console.WriteLine("**** {0} ****", titolo);
            Console.WriteLine();
            Console.WriteLine(sottotitolo);
            Console.WriteLine();
        }

        internal static int ClientRequest()
        {
            Console.Write("/tInserisci il nome: ");
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
    }
    
}
