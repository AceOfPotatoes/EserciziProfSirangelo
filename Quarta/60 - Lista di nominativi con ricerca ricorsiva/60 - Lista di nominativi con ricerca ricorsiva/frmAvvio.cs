using System;
using System.Drawing;
using System.Windows.Forms;

namespace _60___Lista_di_nominativi_con_ricerca_ricorsiva
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        string[] Elenco;
        int N = 0;
        const int Max = 20;

        private void frmAvvio_Load(object sender, EventArgs e)
        {           
            Elenco = new string[Max];
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            if (N < Max)
            {
                string NomeDaAggiungere = txtNomeDaAggiungere.Text.ToUpper();
                Elenco[N] = NomeDaAggiungere;
                N++;
                OrdinaElenco(Elenco);                
                VisualizzaElencoInListBox(Elenco);
                txtNomeDaAggiungere.Clear();
                txtNomeDaAggiungere.Focus();
            }
            else
                MessageBox.Show("Inserito il numero massimo di nominativi!!!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private int TrovaPosizione(string NomeDaCercare, string[] Elenco, int LimiteInferiore, int LimiteSuperiore)
        {
            int Centro = (LimiteInferiore + LimiteSuperiore) / 2;
            if (Elenco[Centro] == NomeDaCercare)
                return Centro;
            else if (LimiteSuperiore < LimiteInferiore)
                return -1;
            else
                //se string.Compare < 0 prima stringa più piccola
                if(string.Compare(NomeDaCercare, Elenco[Centro]) < 0)
                    return TrovaPosizione(NomeDaCercare, Elenco, LimiteInferiore, Centro - 1);
                else
                    return TrovaPosizione(NomeDaCercare, Elenco, Centro + 1, LimiteSuperiore);

        }

        private void plsTerminaInput_Click(object sender, EventArgs e)
        {
            Size = new Size(289, 508);
            plsAggiungi.Enabled = false;
        }

        private void plsRicerca_Click(object sender, EventArgs e)
        {
            int LimiteInferiore = 0;
            int LimiteSuperiore = N - 1;
            string NomeDaCercare = txtNomeDaCercare.Text.ToUpper();
            int PosizioneRicercato = TrovaPosizione(NomeDaCercare, Elenco, LimiteInferiore, LimiteSuperiore);
            if (PosizioneRicercato != -1)
                MessageBox.Show("La posizione del nominativo ricercato nel vettore è la n°: " + PosizioneRicercato.ToString());
            else
                MessageBox.Show("Il nominativo ricercato non è presente");
        }

        private void VisualizzaElencoInListBox(string[] Elenco)
        {
            lstNominativi.Items.Clear();
            for (int k = 0; k < N; k++)
                lstNominativi.Items.Add(Elenco[k]);                
        }

        private void OrdinaElenco(string[] Elenco)
        {
            for (int k1 = 0; k1 <= N - 2; k1++)
            {
                int PosMin = k1;

                for (int k2 = k1 + 1; k2 <= N - 1; k2++)
                    if (string.Compare(Elenco[k2], Elenco[PosMin]) < 0)
                        PosMin = k2;

                string Temp = Elenco[k1];
                Elenco[k1] = Elenco[PosMin];
                Elenco[PosMin] = Temp;
            }
        }
    }
}
