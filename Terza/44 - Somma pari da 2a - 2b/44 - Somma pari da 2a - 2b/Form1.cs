using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44___Somma_pari_da_2a___2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt16(txtA.Text);
            int B = Convert.ToInt16(txtB.Text);
            int Somma = 0;

            if (A < B)
            {
                for (int K = 2 * A; K <= 2 * B; K += 2)                
                    Somma += K;

                MessageBox.Show(Somma.ToString());                
            }                                  
            else
                MessageBox.Show("A deve essere < di B!!!");
        }
    }
}
