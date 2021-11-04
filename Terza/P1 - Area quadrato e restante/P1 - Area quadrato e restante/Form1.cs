using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1___Area_quadrato_e_restante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            double L1;
            double L2;
            double AQ;
            double ARET;
            double AR;

            L1 = Convert.ToDouble(txtL1.Text);
            L2 = Convert.ToDouble(txtL2.Text);
            AQ = L1 * L1;
            ARET = L1 * L2;
            AR = ARET - AQ;

            lblAq.Text = AQ.ToString();
            lblAr.Text = AR.ToString();

        }
    }
}
