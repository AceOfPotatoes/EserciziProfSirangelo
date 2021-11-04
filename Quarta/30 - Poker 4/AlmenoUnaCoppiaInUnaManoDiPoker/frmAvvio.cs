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
            if (MazzoCarte.PossibileDareCarte())
            {
                ManoGiocatore = new Mazzi();

                for (int K = 0; K < 5; K++)
                    ManoGiocatore.Aggiungi(MazzoCarte.EstraiPrimaCarta());

                ManoGiocatore.VisualizzaInListBox(lstMano5Carte);
                MazzoCarte.VisualizzaInListBox(lstMazzo);
            }
            else
                MessageBox.Show("Carte insufficienti!!");

            ManoGiocatore.Ordina();
            ManoGiocatore.VisualizzaInListBox(lstMano5Carte);

        }



        private void plsVerificaPunteggio_Click(object sender, EventArgs e)
        {
            if(ManoGiocatore.èScalaReale())
                MessageBox.Show("Il giocatore ha in mano una scala reale");
            else if(ManoGiocatore.èColore())
                MessageBox.Show("Il giocatore ha in mano un colore");
            else if(ManoGiocatore.èFull())
                MessageBox.Show("Il giocatore ha in mano un full");
            else if(ManoGiocatore.èScala())
                MessageBox.Show("Il giocatore ha in mano una scala");
            else if(ManoGiocatore.èPoker())
                MessageBox.Show("Il giocatore ha in mano un poker");
            else if (ManoGiocatore.èTris())
                MessageBox.Show("Il giocatore ha in mano un tris");
            else if(ManoGiocatore.èCoppia())
                MessageBox.Show("Il giocatore ha in mano una coppia");
            else
                MessageBox.Show("Il giocatore non ha alcun punto in mano");
        }
    }
}
