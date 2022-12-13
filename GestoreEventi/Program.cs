
using GestoreEventi;
using System;
using System.Runtime.CompilerServices;


Console.WriteLine("Inserisci il Nome dell'evento!");
string NomeEvento = Console.ReadLine();

Console.WriteLine("Inserisci la data dell'evento!");
string DataEvento = Console.ReadLine();

Console.WriteLine("Inserisci la capienza in posti dell'evento!");
int CapienzaMassima =  int.Parse(Console.ReadLine());

Evento Evento1 = new Evento(NomeEvento, DataEvento, CapienzaMassima, 0);

Console.WriteLine(Evento1.GetNomeEvento() + " " + Evento1.GetDataEvento() + " " + Evento1.GetCapienzaEvento() + " " + Evento1.GetPostiPrenotati());

Console.WriteLine("Vuoi inserire delle prenotazioni? Inserisci si/no");

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

Console.WriteLine(Evento1.GetPostiPrenotati());


