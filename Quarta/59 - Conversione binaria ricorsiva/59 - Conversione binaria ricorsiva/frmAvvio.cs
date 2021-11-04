using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _59___Conversione_binaria_ricorsiva
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        private void plsConverti_Click(object sender, EventArgs e)
        {
            int N = (int)numN.Value;
            lblRisultato.Text = Converti(N);
        }

        private string Converti(int N)
        {
            int Resto = N % 2;
            if (N == 1)
                return "1";
            else
                return Converti(N / 2) + Resto;               
        }
    }
}
