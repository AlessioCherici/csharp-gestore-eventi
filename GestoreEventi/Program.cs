
using GestoreEventi;
using System;
using System.Runtime.CompilerServices;


//inizio richiesta input utente

Console.WriteLine("Inserisci il Nome dell'evento!");
string NomeEvento = Console.ReadLine();

Console.WriteLine("Inserisci la data dell'evento!(gg/mm/aaaa");
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












