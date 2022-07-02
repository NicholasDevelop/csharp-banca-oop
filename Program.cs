using csharp_banca_oop;

//inizializzazione
Banca bank = new Banca("Intesa San Paolo");


Cliente fakeClient1 = new Cliente("Giovanni", "Bianchi", "dkajcoawe");
Cliente fakeClient2 = new Cliente("Marco", "Rossi", "kjxzcpvoaew2");
Cliente fakeClient3 = new Cliente("Giulia", "Blu", "cèawmòca56");
Cliente fakeClient4 = new Cliente("Tommaso", "Gialli", "98dacvpwew1");
bank.NewClient(fakeClient1);
bank.NewClient(fakeClient2);
bank.NewClient(fakeClient3);
bank.NewClient(fakeClient4);


Prestito fakeLoan1 = new Prestito(bank.clienti[0], 30000, 120, "05/07/2020", "05/07/2030");
Prestito fakeLoan2 = new Prestito(bank.clienti[0], 10000, 120, "02/09/20218", "02/09/2028");
Prestito fakeLoan3 = new Prestito(bank.clienti[1], 25000, 120, "26/01/2020", "26/01/2030");
Prestito fakeLoan4 = new Prestito(bank.clienti[2], 45000, 120, "17/11/2020", "17/11/2030");
bank.NewLoan(fakeLoan1);
bank.NewLoan(fakeLoan2);
bank.NewLoan(fakeLoan3);
bank.NewLoan(fakeLoan4);


Menu.mainPage(bank);