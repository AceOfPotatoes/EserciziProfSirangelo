using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _58___Potenza_del_2_ricorsiva
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
            lblRisultato.Text = DueAlla(N).ToString();
        }

        private double DueAlla(int N)
        {
            if (N == 0)
                return 1;
            else if (N > 0)
                return 2 * DueAlla(N - 1);
            else
                return 1 / (2 * DueAlla((-N) - 1));
        }
    }
}
