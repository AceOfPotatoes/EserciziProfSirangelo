using System;
using System.Drawing;
using System.Windows.Forms;

namespace _24___Atleti__calciatori
{
    public partial class frmCalciatore : Form
    {
        public frmCalciatore()
        {
            InitializeComponent();
        }

        Calciatore mioCalciatore;

        private void frmCalciatore_Load(object sender, EventArgs e)
        {
            Calciatore.AggiungiRuoli(cmbRuolo);
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            Size = new Size(276, 487);
            mioCalciatore = new Calciatore(txtNominativo.Text, (int)numEtà.Value, txtNazionalità.Text, cmbRuolo.Items[cmbRuolo.SelectedIndex].ToString(), (int)numMaglia.Value, txtSquadra.Text);
            lblDati.Text = mioCalciatore.Testo();            
            plsOver.Visible = true;
            plsJuniores.Visible = true;
        }

        
        private void plsJuniores_Click(object sender, EventArgs e)
        {
            if (mioCalciatore.èJuniores())
                MessageBox.Show("Il calciatore inserito è uno Juniores", "Risultato");
            else
                MessageBox.Show("Il calciatore inserito NON è uno Juniores", "Risultato");
        }

        private void plsOver_Click(object sender, EventArgs e)
        {
            if (mioCalciatore.èOver())
                MessageBox.Show("Il calciatore inserito è un Over", "Risultato");
            else
                MessageBox.Show("Il calciatore inserito NON è un Over", "Risultato");
        }
    }
}
