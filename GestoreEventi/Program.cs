
using GestoreEventi;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;


//inizio richiesta input utente

Console.WriteLine("Inserisci il Nome dell'evento!");
string NomeEvento = Console.ReadLine();

Console.WriteLine("Inserisci la data dell'evento!(gg/mm/aaaa)");
string DataEvento = Console.ReadLine();

Console.WriteLine("Inserisci la capienza in posti dell'evento!");
int CapienzaMassima =  int.Parse(Console.ReadLine());

Evento Evento1 = new Evento(NomeEvento, DataEvento, CapienzaMassima, 0);

Console.WriteLine(Evento1.GetNomeEvento() + " " + Evento1.GetDataEvento() + " " + Evento1.GetCapienzaEvento() + " " + Evento1.GetPostiPrenotati());

//inizio richiesta inserimento prenotazione

Console.WriteLine("Vuoi inserire delle prenotazioni? Inserisci \"si\" o \"no\"");

string CheckPrenotazioni = Console.ReadLine().ToLower();

while (CheckPrenotazioni != "si" && CheckPrenotazioni != "no")
    {
    Console.WriteLine("Input errato, inserisci si/no");
    CheckPrenotazioni = Console.ReadLine().ToLower();
    }

if (CheckPrenotazioni == "si")
    {
    Console.WriteLine("Inserisci il numero di posti da prenotare!");
    int PostiAggiunti = int.Parse(Console.ReadLine());
    Evento1.PrenotaPosti(PostiAggiunti);
    }



int PostiDisponibili = Evento1.GetCapienzaEvento() - Evento1.GetPostiPrenotati();

Console.WriteLine("I posti prenotati sono: " + Evento1.GetPostiPrenotati());
Console.WriteLine("I posti rimanenti sono: " + PostiDisponibili);

Console.WriteLine("Vuoi disdire dei posti? Inserisci \"si\" o \"no\"");
string CheckDisdire = Console.ReadLine().ToLower();
while (CheckDisdire != "si" && CheckDisdire != "no")
    {
    Console.WriteLine("Input errato, inserisci si/no");
    CheckDisdire = Console.ReadLine().ToLower();
    }

while (CheckDisdire == "si")
    {
    Console.WriteLine("Inserisci il numero di posti da disdire!");
    int PostiRimossi = int.Parse(Console.ReadLine());
    Evento1.RimuoviPostiPrenotati(PostiRimossi);
    Console.WriteLine("I posti prenotati sono: " + Evento1.GetPostiPrenotati());
    PostiDisponibili = Evento1.GetCapienzaEvento() - Evento1.GetPostiPrenotati();
    Console.WriteLine("I posti rimanenti sono: " + PostiDisponibili);
    Console.WriteLine("Vuoi disdire altri prosti? Inserisci \"si\" o \"no\" ");
    CheckDisdire = Console.ReadLine().ToLower();
    }

//Inizio richiesta input utente per ProgrammaEventi

Console.WriteLine("Inserisci il nome del Programma Eventi!");
string Titolo = Console.ReadLine();

ProgrammaEventi Programma1 = new ProgrammaEventi(Titolo);

Console.WriteLine("Quanti Eventi vuoi aggiungere?");
int NumeroEventiDaAggiungere = int.Parse(Console.ReadLine());

while (Programma1.GetLista().Count != NumeroEventiDaAggiungere)
    {

    Console.WriteLine("Inserisci il Nome dell'evento!");
    string Nome = Console.ReadLine();

    Console.WriteLine("Inserisci la data dell'evento!(gg/mm/aaaa)");
    string Data = Console.ReadLine();

    Console.WriteLine("Inserisci la capienza in posti dell'evento!");
    int Capienza = int.Parse(Console.ReadLine());

    Evento EventoUtente = new Evento(Nome, Data, Capienza, 0);

    Programma1.AggiungiEvento(EventoUtente);
    }

Console.WriteLine("Inserisci la data in cui vuoi ricercare un evento!(gg/mm/aaaa)");
string DataInserita = Console.ReadLine();
DateTime DataConvertita = DateTime.ParseExact(DataInserita, "dd/MM/yyyy", CultureInfo.InvariantCulture);

 List<Evento> ListaEventiTrovatiInData = Programma1.ElencaEventiInData(DataConvertita);

string StringaRicercata = ProgrammaEventi.ReturnListaPerData(ListaEventiTrovatiInData);

Console.WriteLine(StringaRicercata);

Programma1.SvuotaLista();













