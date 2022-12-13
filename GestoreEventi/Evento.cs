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
        private string DataEvento;
        private int CapienzaMassima;
        private int PostiPrenotati;

        public Evento(string NomeEvento, string DataEvento, int CapienzaEvento, int PostiPrenotati)
            {
            SetNomeEvento(NomeEvento);
            SetDataEvento(DataEvento);
            this.CapienzaMassima = CapienzaEvento;
            this.PostiPrenotati = 0;
            }

        //--------------------------------- Metodi Get ---------------------------------

        public string GetNomeEvento()
            {
            return this.NomeEvento;
            }
        public string GetDataEvento()
            {
            return this.DataEvento;
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
            this.DataEvento = DateTime.ToString(DataInserita);
            }      
        }
    }

