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
        Mazzi ManoGiocatore2;

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
            if (MazzoCarte.PossibileDareCarte())
            {
                ManoGiocatore1 = new Mazzi();

                for (int K = 0; K < 5; K++)
                    ManoGiocatore1.Aggiungi(MazzoCarte.EstraiPrimaCarta());

                ManoGiocatore1.VisualizzaInListBox(lstManoGiocatore1);
                MazzoCarte.VisualizzaInListBox(lstMazzo);
            }
            else
                MessageBox.Show("Carte insufficienti!!");            
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
            int Indice = lstManoGiocatore1.SelectedIndex;

            if (Indice >= 0)
            {
                MazzoCarte.Aggiungi(ManoGiocatore1.EstraiCartaInPosizione((byte)Indice));
                ManoGiocatore1.Aggiungi(MazzoCarte.EstraiPrimaCarta());
            }

            ManoGiocatore1.VisualizzaInListBox(lstManoGiocatore1);
            MazzoCarte.VisualizzaInListBox(lstMazzo);
        }

        private void plsCarteG2_Click(object sender, EventArgs e)
        {
            if (MazzoCarte.PossibileDareCarte())
            {
                ManoGiocatore2 = new Mazzi();

                for (int K = 0; K < 5; K++)
                    ManoGiocatore2.Aggiungi(MazzoCarte.EstraiPrimaCarta());

                ManoGiocatore2.VisualizzaInListBox(lstManoGiocatore2);
                MazzoCarte.VisualizzaInListBox(lstMazzo);
            }
            
        }

        private void plsCartaAlta_Click(object sender, EventArgs e)
        {           
            Mazzi CarteAlte = new Mazzi();

            CarteAlte.Aggiungi(ManoGiocatore1.CartaAltaMazzo());
            CarteAlte.Aggiungi(ManoGiocatore2.CartaAltaMazzo());

            if(CarteAlte.CartaAltaMazzo().UgualeA(ManoGiocatore1.CartaAltaMazzo()))
                MessageBox.Show("G1 ha la carta più alta, ovvero: " + ManoGiocatore1.CartaAltaMazzo().ToString(), "CARTA ALTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("G2 ha la carta più alta, ovvero: " + ManoGiocatore2.CartaAltaMazzo().ToString(), "CARTA ALTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
