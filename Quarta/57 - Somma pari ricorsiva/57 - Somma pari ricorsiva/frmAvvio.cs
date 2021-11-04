using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57___Somma_pari_ricorsiva
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            int N = (int)numN.Value;
            lblRisultato.Text = SommaPari(N).ToString();

        }

        private int SommaPari(int N)
        {
            if (N == 1)
                return 2;
            else
                return 2 * N + SommaPari(N - 1);
        }
    }
}
