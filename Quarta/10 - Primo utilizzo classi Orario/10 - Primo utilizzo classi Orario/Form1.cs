using System;
using System.Windows.Forms;

namespace _10___Primo_utilizzo_classi_Orario
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        Orario O1;
        Orario O2;


        private void frmAvvio_Load(object sender, EventArgs e)
        {
        }

        private void plsAM_Click(object sender, EventArgs e)
        {
            O1 = new Orario(Convert.ToInt32(numOra.Value), Convert.ToInt32(numMin.Value));
            O2 = new Orario(Convert.ToInt32(numOra2.Value), Convert.ToInt32(numMin2.Value));
            if (O1.AntiMeridiano())
                MessageBox.Show("L'orario O1 inserito è antimeridiano", "RISULTATO");
            else
                MessageBox.Show("L'orario O1 inserito NON è antimeridiano", "RISULTATO");
        }

        private void plsConfronta_Click(object sender, EventArgs e)
        {
            O1 = new Orario(Convert.ToInt32(numOra.Value), Convert.ToInt32(numMin.Value));
            O2 = new Orario(Convert.ToInt32(numOra2.Value), Convert.ToInt32(numMin2.Value));
            if (O1.PrecedenteA(O2))
                MessageBox.Show("L'orario O1 inserito è precedente ad O2", "RISULTATO");
            else
                MessageBox.Show("L'orario O1 inserito NON è precedente ad O2", "RISULTATO");            
        }

        private void plsMezzanotte_Click(object sender, EventArgs e)
        {
            O1 = new Orario(Convert.ToInt32(numOra.Value), Convert.ToInt32(numMin.Value));
            O2 = new Orario(Convert.ToInt32(numOra2.Value), Convert.ToInt32(numMin2.Value));
            MessageBox.Show("Da mezzanotte ad O1 sono trascorsi " +O1.MinutiDaScorsaMezzanotte()+ " minuti");
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            O1 = new Orario(Convert.ToInt32(numOra.Value), Convert.ToInt32(numMin.Value));
            O2 = new Orario(Convert.ToInt32(numOra2.Value), Convert.ToInt32(numMin2.Value));
        }
    }
}
