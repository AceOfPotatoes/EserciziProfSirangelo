using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19___Articolo_negozio
{
    class Articolo
    {
        private int prezlist;
        private int sconto;
        private int pezzdisp;
        private int prezven;
        private string desc;

        public Articolo(int prezlist, int sconto, int pezzdisp, string desc)
        {
            this.prezlist = prezlist;
            this.sconto = sconto;
            this.pezzdisp = pezzdisp;
            this.desc = desc;
        }

        public string Descrizione
        {
            get { return desc; }
            set { desc = value; }
        }

        public int PrezzoListino
        {
            get { return prezlist; }
            set
            {
                if (value > 0)
                    prezlist = value;
                else
                    MessageBox.Show("Prezzo minore di 0€", "ATTENZIONE");
            }
        }

        public int Sconto
        {
            get { return sconto; }
            set
            {
                if (value < 100 && value > 0)
                    sconto = value;
                else
                    MessageBox.Show("Attenzione sconto inserito non valido", "ATTENZIONE");
            }
        }

        public int PezziDisponibili
        {
            get { return pezzdisp; }
            set { pezzdisp = value; }
        }

        public int PrezzoVendita
        {
            get { return CalcolaPrezzoVendita(); }
            set
            {
                if (value > 0)
                    prezven = value;
                else
                    MessageBox.Show("Prezzo minore di 0€", "ATTENZIONE");
            }
        }

        public int CalcolaRicavoSvendita()
        {
            return PrezzoVendita * PezziDisponibili;
        }

        public void AumentaPezzi(int N)
        {
            PezziDisponibili += N;
        }

        private int CalcolaPrezzoVendita()
        {
            int DaScontare = (PrezzoListino * Sconto) / 100;
            return PrezzoListino - DaScontare;
        }


    }
}
