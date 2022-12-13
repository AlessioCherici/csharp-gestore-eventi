using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
    {
    public class Evento
        {
        private string NomeEvento;
        private DateTime DataEvento;
        private int CapienzaMassima;
        private int PostiPrenotati;

        public Evento(string NomeEvento, string DataEvento, int CapienzaMassima, int PostiPrenotati)
            {
            SetNomeEvento(NomeEvento);
            SetDataEvento(DataEvento);
            SetCapienzaMassima(CapienzaMassima);
            SetPostiPrenotati(0);
            }

        //--------------------------------- Metodi Get ---------------------------------

        public string GetNomeEvento()
            {
            return this.NomeEvento;
            }
        public string GetDataEvento()
            {
            return this.DataEvento.ToShortDateString();
            }
        public int GetCapienzaEvento()
            {
            return this.CapienzaMassima;
            }
        public int GetPostiPrenotati()
            {
            return this.PostiPrenotati;
            }
        //--------------------------------- Metodi set ---------------------------------
        public void SetNomeEvento(string NomeEvento)
            {
            if (string.IsNullOrEmpty(NomeEvento))
                {
                throw new Exception("Il nome evento non può essere vuoto!");
                }
            this.NomeEvento = NomeEvento;
            }
        public void SetDataEvento(string DataEvento)
            {
            if (string.IsNullOrEmpty(DataEvento))
                {
                throw new Exception("La data non può essere vuota!");
                }
            DateTime DataInserita = DateTime.ParseExact(DataEvento, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime DataOdierna = DateTime.Today;

            if (DataInserita < DataOdierna)
                {
                throw new Exception("La data non può essere inferiore a quella odierna!");
                }          
            this.DataEvento = DataInserita;
            }
        private void SetCapienzaMassima(int CapienzaMassima)
            {
            if (CapienzaMassima <= 0)
                {
                throw new Exception("La capienza massima non può essere minore o uguale a 0!");
                }
            this.CapienzaMassima = CapienzaMassima;
            }
        private void SetPostiPrenotati(int PostiPrenotati)
            {

            if (PostiPrenotati < 0)
                {
                throw new Exception("Il numero di posti prenotati non può essere minore di 0!");
                }

            if (PostiPrenotati > CapienzaMassima)
                {
                throw new Exception("Il numero di posti prenotati non può essere maggiore dei posti prenotabili!");
                }
            }
        //------------------------------- Metodi prenotazione --------------------------------

        public int PrenotaPosti(int PostiAggiunti) 
            {
            if (this.DataEvento < DateTime.Now)
                {
                throw new Exception("Non puoi prenotare posti per un evento gia avvenuto");
                }
            if (PostiAggiunti <= 0)
                {
                throw new Exception("Non puoi aggiungere un numero negativo o pari a 0 di posti");
                }
            int PostiFinali = PostiAggiunti + this.PostiPrenotati;
            if (PostiFinali > this.CapienzaMassima)
                {
                throw new Exception("Hai raggiunto il numero massimo di posti prenotabili, probabilmente l'evento è pieno");
                }
            return PostiFinali;
            }
        public int RimuoviPostiPrenotati(int PostiDaRimuovere)
            {
            if (this.DataEvento < DateTime.Now)
                {
                throw new Exception("Non puoi rimuovere posti per un evento gia avvenuto");
                }
            if (PostiDaRimuovere - PostiPrenotati < 0)
                {
                throw new Exception("Non puoi rimuovere un numero di posti maggiore dei posti prenotati!");
                }
            int PostiFinali = PostiPrenotati - PostiDaRimuovere;
            return PostiFinali;
            }
        public override string ToString()
            {
            return this.GetNomeEvento() + " - " + GetDataEvento();
            }
        }
    }



