//una serie di istanze per "popolare" il nostro "fake db"// 2 o 3 utenti -> registrati// 2 o 3 libri --> tutti disponibili// Gli utenti si possono registrare specificando i dati ...// Biblioteca online// 1. registrati// 2. login//login // email: ..// passowrd: ..// Biblioteca online// 1. Cerca libri// 2. Cerca dvd// Registrazione// Scrivmi il nome: // scrivimi il cognome.. etc// scrivi la passowrd: // Menu libro (titolo)// 1. visualizza dettagli libro// 2. richiedi prestito// 3. restitutisci// tutti i menu hanno esci o torna indietro
using csharp_biblioteca;

Biblioteca newBiblio = new Biblioteca();
Utente user1 = new Utente("mail@prova.it", "1234");
user1.name = "Giuseppe";
user1.surname = "Mirizzi";
newBiblio.AddUser(user1);
Utente user2 = new Utente("mail@prova.it", "1234");
user2.name = "Paolo";
user2.surname = "Sempronio";
newBiblio.AddUser(user2);
Utente user3 = new Utente("mail@prova.it", "1234");
user3.name = "Gianluca";
user3.surname = "Tizio";
newBiblio.AddUser(user3);


