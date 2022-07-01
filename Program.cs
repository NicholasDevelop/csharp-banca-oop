using csharp_banca_oop;

//inizializzazione
Banca bank = new Banca("Intesa San Paolo");


/* Aggiunta nuovo cliente */
Cliente newClient = Banca.CreateClient();
bank.NewClient(newClient);


/* Modifica un cliente */
bank.ClientList();   //presentare una lista di clienti

int indexClient = Banca.ClientRequest();      //L'utente seleziona il cliente da modificare
Cliente client = bank.GetClient(indexClient);  //L'utente seleziona il cliente da modificare
Banca.ModifyClient(client);                     //Modifica cliente


/* Ricerca di un cliente */



/* Aggiunta di un prestito */
Prestito newLoan = Banca.CreateLoan();
bank.NewLoan(newLoan);