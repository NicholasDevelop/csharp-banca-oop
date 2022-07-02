using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Menu
    {
        public static void mainPage(Banca banca)
        {
            Console.WriteLine("\n*** MENU BANCA ***");

            Console.WriteLine("1. Lista clienti");
            Console.WriteLine("2. Aggiungi cliente");
            Console.WriteLine("3. Modifica cliente");
            Console.WriteLine("4. Ricerca cliente");
            Console.WriteLine("5. Aggiunta prestito");
            Console.WriteLine("6. Lista prestiti");
            Console.WriteLine("7. Esci dal programma\n");

            uint input = Convert.ToUInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("---Lista Clienti---");
                    banca.ClientList();
                    mainPage(banca);
                    break;
                case 2:
                    Console.WriteLine("---Aggiunta Cliente---");
                    Cliente newClient = Banca.CreateClient();
                    banca.NewClient(newClient);
                    mainPage(banca);
                    break;
                case 3:
                    Console.WriteLine("---Modifica Cliente---");
                    int indexClient = Banca.ClientRequest();
                    Cliente clientMod = banca.GetClient(indexClient);
                    Banca.ModifyClient(clientMod);
                    mainPage(banca);
                    break;
                case 4:
                    Console.WriteLine("---Ricerca Cliente---");
                    int selected = Banca.ClientRequest();
                    Cliente clientSelected = banca.GetClient(selected);
                    Console.WriteLine(clientSelected.Name + "  " + clientSelected.Surname + "  " + clientSelected.FiscalCode);
                    mainPage(banca);
                    break;
                case 5:
                    Console.WriteLine("---Inserimento Prestito---");
                    banca.ClientList();

                    Console.Write("/nInserire l'indice del cliente:");
                    int numClient = int.Parse(Console.ReadLine());
                    Cliente client = banca.GetClient(numClient);

                    Console.Write("Inserire l'ammontare del prestito:");
                    float amount = float.Parse(Console.ReadLine());

                    Console.Write("Inserire le rate del prestito:");
                    int rate = int.Parse(Console.ReadLine());

                    Console.WriteLine("/n/nData inizio del prestito/n");
                    string startDate = DateTime.Today.ToString("dd/mm/yyyy");
                    Console.WriteLine(startDate);

                    Console.WriteLine("Data di fine prestito/n/n");
                    Console.Write("Inserire il giorno:");
                    int endLoanDay = int.Parse(Console.ReadLine());

                    Console.Write("Inserire il mese:");
                    int endLoanMonth = int.Parse(Console.ReadLine());

                    Console.Write("Inserire l'anno:");
                    int endLoanYear = int.Parse(Console.ReadLine());

                    string endDate = "";

                    Prestito loan = banca.CreateLoan(client, amount, rate, startDate, endDate);
                    Console.WriteLine();
                    Console.WriteLine($"Lista prestiti di banca {banca.Name}");
                    banca.LoanList();
                    mainPage(banca);
                    break;
                case 6:
                    banca.LoanList();
                    mainPage(banca);
                    break;
                case 7:
                    return;
                    break;

            }
        }
    }
}
