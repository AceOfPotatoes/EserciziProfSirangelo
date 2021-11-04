using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31___Punteggio_calcio_multiform
{
    public partial class frmInputGolSegnati : Form
    {
        public frmInputGolSegnati()
        {
            InitializeComponent();
        }

        public int GolSquadra1;
        public int GolSquadra2;
        public string NomeSquadra1;
        public string NomeSquadra2;

        private void plsInviaDati_Click(object sender, EventArgs e)
        {
            GolSquadra1 = (int)numGol1.Value;
            GolSquadra2 = (int)numGol2.Value;
            NomeSquadra1 = txtNomeSquadra1.Text;
            NomeSquadra2 = txtNomeSquadra2.Text;
            Close();
        }

        private void txtNomeSquadra1_TextChanged(object sender, EventArgs e)
        {
            lblSquadra1.Text = txtNomeSquadra1.Text;
        }

        private void txtNomeSquadra2_TextChanged(object sender, EventArgs e)
        {
            lblSquadra2.Text = txtNomeSquadra2.Text;
        }
    }
}
