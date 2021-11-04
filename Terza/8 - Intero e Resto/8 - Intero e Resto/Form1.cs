using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8___Intero_e_Resto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            int N1 = Convert.ToInt32(txtN1.Text);
            int N2 = Convert.ToInt32(txtN2.Text);
            int Intero;
            int Resto;

            Intero = N1 / N2;
            Resto = N1 % N2;

            lblResto.Text = Resto.ToString();
            lblIntero.Text = Intero.ToString();
        }
    }
}
