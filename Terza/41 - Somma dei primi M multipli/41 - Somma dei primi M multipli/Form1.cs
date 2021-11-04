using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41___Somma_dei_primi_M_multipli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            int M = Convert.ToInt16(txtM.Text);
            int N = Convert.ToInt16(txtN.Text);
            int O = N;
            int Somma = 0;
            int K = 1;

            do
            {
                O += N;
                Somma += O;                
                K++;           
            }
            while (K <= M);

            MessageBox.Show(Somma.ToString());
        }       
    }
}
