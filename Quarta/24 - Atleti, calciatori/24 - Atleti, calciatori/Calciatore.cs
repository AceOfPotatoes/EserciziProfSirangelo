using System.Windows.Forms;

namespace _24___Atleti__calciatori
{
    class Calciatore : Atleta
    {
        public string Ruolo;
        private int NumeroMaglia;
        public string Squadra;

        public Calciatore(string NuovoNominativo, int NuovaEtà, string NuovaNazionalità, string NuovoRuolo, int NuovoNumeroMaglia, string NuovaSquadra) : base(NuovoNominativo, NuovaEtà, NuovaNazionalità)
        {
            Ruolo = NuovoRuolo;
            NumeroMaglia = NuovoNumeroMaglia;
            Squadra = NuovaSquadra;
        }

        public override bool èOver()
        {
            if (Ruolo == "PORTIERE")
            {
                return Età > 40;
            }
            else
            {
                return Età > 35;
            }
        }

        public override string Testo()
        {
            return base.Testo() + "Ruolo: " + Ruolo + (char)13 +
                                  "N° Maglia: " + NumeroMaglia + (char)13 +
                                   "Squadra: " + Squadra + (char)13;
        }

        public static void AggiungiRuoli(ComboBox cmbRuolo)
        {
            cmbRuolo.Items.Add("PORTIERE");
            cmbRuolo.Items.Add("DIFENSORE");
            cmbRuolo.Items.Add("CENTROCAMPISTA");
            cmbRuolo.Items.Add("ATTACCANTE");
        }
    }
}