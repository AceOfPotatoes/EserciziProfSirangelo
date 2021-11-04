using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6___Triplo_e_Potenza_di_un_Intero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int N = 0;
        int A = 0;
        int B = 0;
        

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(txtNumero.Text);
            A = N * 3;
            B = N * N * N;
            lblTriplo.Text = A.ToString();
            lblCubo.Text = B.ToString();
        }
    }
}
