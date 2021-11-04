using System;
using System.Windows.Forms;

namespace _13___Statistiche_partita_con_proprietà_classi
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        Partita P1;

        private void plsTotocalcio_Click(object sender, EventArgs e)
        {
            P1 = new Partita();
            P1.Sq1 = txtSq1.Text;
            P1.Sq2 = txtSq2.Text;
            P1.Gol1 = Convert.ToInt16(numSq1.Value);
            P1.Gol2 = Convert.ToInt16(numSq2.Value);
            MessageBox.Show(P1.Totocalcio(), "SEGNO TOTOCALCIO");
        }

        private void plsVittoria_Click(object sender, EventArgs e)
        {
            P1 = new Partita();
            P1.Sq1 = txtSq1.Text;
            P1.Sq2 = txtSq2.Text;
            P1.Gol1 = Convert.ToInt16(numSq1.Value);
            P1.Gol2 = Convert.ToInt16(numSq2.Value);
            MessageBox.Show(P1.SquadraVincitrice(txtSq1, txtSq2), "SQUADRA VINCITRICE");
        }

        private void plsGol_Click(object sender, EventArgs e)
        {
            P1 = new Partita();
            P1.Sq1 = txtSq1.Text;
            P1.Sq2 = txtSq2.Text;
            P1.Gol1 = Convert.ToInt16(numSq1.Value);
            P1.Gol2 = Convert.ToInt16(numSq2.Value);
            MessageBox.Show("La somma dei gol è " + P1.SommaGol(), "SOMMA GOL");
        }
    }
}
