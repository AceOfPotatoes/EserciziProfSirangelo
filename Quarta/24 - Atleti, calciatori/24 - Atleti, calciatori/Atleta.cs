using System;

namespace _24___Atleti__calciatori
{
    abstract class Atleta
    {
        public string Nominativo;
        private int età;
        public string Nazionalità;

        public int Età
        {
            get { return età; }
            set
            {
                if (value > 0 && value < 100)
                    età = value;
            }
        }

        public Atleta(string NuovoNominativo, int NuovaEtà, string NuovaNazionalità)
        {
            Nominativo = NuovoNominativo;
            Età = NuovaEtà;
            Nazionalità = NuovaNazionalità;
        }

        public bool èJuniores()
        {
            return Età < 18;
        }

        public abstract bool èOver();
        public virtual string Testo()
        {
            return "Nome: " + Nominativo + (char)13 + 
                    "Età: " + Età + (char)13 + 
                    "Nazionalità: " + Nazionalità + (char)13;
        }
    }
}
