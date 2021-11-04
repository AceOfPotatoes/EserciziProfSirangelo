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
        Mazzi ManoGiocatore1;

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
            if (ManoGiocatore1.PossibileDareCarte())
            {
                ManoGiocatore1 = new Mazzi();

                for (int K = 0; K < 5; K++)
                    ManoGiocatore1.Aggiungi(MazzoCarte.EstraiPrimaCarta());

                ManoGiocatore1.VisualizzaInListBox(lstMano5Carte);
                MazzoCarte.VisualizzaInListBox(lstMazzo);
            }            
        }



        private void plsVerificaCoppia_Click(object sender, EventArgs e)
        {
            if (ManoGiocatore1.e_Coppia())
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
                ManoGiocatore1.Aggiungi(MazzoCarte.EstraiPrimaCarta());
            }

            ManoGiocatore1.VisualizzaInListBox(lstMano5Carte);
            MazzoCarte.VisualizzaInListBox(lstMazzo);
        }
    }
}
