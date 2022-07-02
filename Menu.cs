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
                    mainPage(banca);
                    break;
                case 5:
                    Console.WriteLine("---Inserimento Prestito---");
                    banca.ClientList();
                    int numClient = Banca.ClientRequest();
                    Cliente client = banca.GetClient(numClient);
                    Console.WriteLine("A quanto ammonta il prestito?");
                    float amount = float.Parse(Console.ReadLine());
                    Prestito loan = banca.CreateLoan(client, amount);
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
