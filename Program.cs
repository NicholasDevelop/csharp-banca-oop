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


Menu.mainPage(bank);