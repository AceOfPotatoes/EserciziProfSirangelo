using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45___Da_N_a_1_tranne_divisibili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(txtN.Text);
            int P = Convert.ToInt16(txtP.Text);
            int Somma = 0;

            for(int K = N; K>=1; K--)
            {

                if (K % P != 0)
                {
                    MessageBox.Show(K.ToString());
                    Somma += K;
                }
                                                                                                    
            }

            MessageBox.Show("La somma di tutti i numeri visualizzati è "+Somma);
        }
    }
}
