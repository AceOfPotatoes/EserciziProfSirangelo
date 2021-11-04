using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int L1;
        int L2;
        int P;
        int A;

        private void button1_Click(object sender, EventArgs e)
        {
            L1 = Convert.ToInt32(txtL1.Text);
            L2 = Convert.ToInt32(txtL2.Text);
            P = (L1 + L2) * 2;
            A = L1 * L2;
            lblPerimetro.Text = P.ToString();
            lblArea.Text = A.ToString();




        }
    }
}
