using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
    {
    public class ProgrammaEventi
        {
        private string Titolo;
        private List<Evento> ListaEventi;

        public ProgrammaEventi(string titolo)
            {
            this.Titolo = titolo;
            this.ListaEventi = new List<Evento>(); 
            }
        //------------------------------ Metodo get ------------------------------------

        private string GetTitolo()
            {
            return this.Titolo;
            }
        //------------------------------ Metodi lista ------------------------------------

        //Metodo per aggiungere evento
        public void AggiungiEvento(Evento EventoInserito)
            {
            ListaEventi.Add(EventoInserito);
            }
        //Metodo per ricercare evento per data
        public List<Evento> ElencaEventiInData(DateTime Data)
            {
            List<Evento> ListaPerData = new List<Evento>();

            foreach(Evento EventoInData in ListaEventi)
                {               
                if (EventoInData.GetDataEvento() == Data.ToShortDateString())
                    {
                    ListaPerData.Add(EventoInData);
                    }
                }
            return ListaPerData;
            }
        //Metodo per portare a stringa una data lista
        public static string StampaListaPerData(List<Evento> ListaInserita)
            {
            string ListaAStringa = string.Join("\n", ListaInserita);
            return ListaAStringa;
            }

        //Metodo che restituisce Eventi presenti in lista
        public void StampaListaGenerico(List<Evento> ListaEventi)
            {
            string ListaAStringa = string.Join("\n", ListaEventi);
            Console.Write(ListaAStringa);
            }

        //Metodo per svuotare lista
        public void SvuotaLista(List<Evento> ListaEventi)
            {
            ListaEventi.Clear();
            }
        //Metodo stampa programma eventi
        public void StampaProgramma()
            {
            Console.WriteLine(this.GetTitolo() + "\n");
            foreach(Evento Evento in ListaEventi)
                {
                Console.WriteLine(Evento.ToString());
                }
            }
        }
    }
