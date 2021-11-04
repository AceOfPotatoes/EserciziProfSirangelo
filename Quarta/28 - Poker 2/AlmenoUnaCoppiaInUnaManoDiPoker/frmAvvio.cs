using System;
using System.Windows.Forms;

namespace AlmenoUnaCoppiaInUnaManoDiPoker
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        // dichiariamo (ma, per ora, non creiamo) DUE mazzi di carte:
        // il mazzo principale e la "mano" del giocatore ...

        Mazzi MazzoCarte;
        Mazzi ManoGiocatore;

        private void plsCreaMazzo_Click(object sender, EventArgs e)
        {
            MazzoCarte = new Mazzi(52);
            MazzoCarte.VisualizzaInListBox(lstMazzo);
        }



        private void plsMischiaMazzo_Click(object sender, EventArgs e)
        {
            MazzoCarte.Mischia();
            MazzoCarte.VisualizzaInListBox(lstMazzo);
        }



        private void plsDaiLe5Carte_Click(object sender, EventArgs e)
        {
            ManoGiocatore = new Mazzi();

            for(int K = 0; K < 5; K++)            
                ManoGiocatore.Aggiungi(MazzoCarte.EstraiPrimaCarta());

            ManoGiocatore.VisualizzaInListBox(lstMano5Carte);
            MazzoCarte.VisualizzaInListBox(lstMazzo);
        }



        private void plsVerificaCoppia_Click(object sender, EventArgs e)
        {
            if (ManoGiocatore.e_Coppia())
                MessageBox.Show("Hai una coppia in mano", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("NON hai una coppia in mano", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void plsScambia_Click(object sender, EventArgs e)
        {
            int Indice = lstMano5Carte.SelectedIndex;

            if (Indice >= 0)
            {
                MazzoCarte.Aggiungi(ManoGiocatore.EstraiCartaInPosizione((byte)Indice));
                ManoGiocatore.Aggiungi(MazzoCarte.EstraiPrimaCarta());
            }

            ManoGiocatore.VisualizzaInListBox(lstMano5Carte);
            MazzoCarte.VisualizzaInListBox(lstMazzo);
        }

        private void plsScarta_Click(object sender, EventArgs e)
        {
            int Indice = lstMano5Carte.SelectedIndex;
            if (Indice != -1)
                MazzoCarte.Aggiungi(ManoGiocatore.EstraiCartaInPosizione((byte)Indice));
            else
                MessageBox.Show("Nessuna carta selezionata", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            ManoGiocatore.VisualizzaInListBox(lstMano5Carte);
            MazzoCarte.VisualizzaInListBox(lstMazzo);
        }

        private void plsDistribuisciMancanti_Click(object sender, EventArgs e)
        {
            int NumeroCarteMano = ManoGiocatore.NumeroCarteNellaMano();
            for (int K = 1; K <= 5 - NumeroCarteMano; K++)
            {
                ManoGiocatore.Aggiungi(MazzoCarte.EstraiPrimaCarta());
            }
            ManoGiocatore.VisualizzaInListBox(lstMano5Carte);
        }
    }
}
