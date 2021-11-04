using System;
using System.Windows.Forms;

namespace _12___Elenco_nominativi_classe
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        Elenco E;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            E = new Elenco();
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            E.Aggiungi(txtNominativo.Text);
            E.Visualizza(lstElenco);
            txtNominativo.Clear();
            txtNominativo.Focus();
        }

        private void plsElimina_Click(object sender, EventArgs e)
        {
            int Pos = lstElenco.SelectedIndex;
            if (Pos >= 0)
            {
                E.Rimuovi(Pos);
                E.Visualizza(lstElenco);
            }           
        }

        private void plsOrdina_Click(object sender, EventArgs e)
        {
            E.Ordina();
            E.Visualizza(lstElenco);
        }

    }
}
