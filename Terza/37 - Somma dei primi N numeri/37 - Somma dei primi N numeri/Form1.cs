using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37___Somma_dei_primi_N_numeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(txtN.Text);
            int Somma = 0;
            int K = 1;

            do
            {
                Somma += K;
                K++;
            }
            while (K <= N);

            MessageBox.Show(Somma.ToString());
        }
    }
}
