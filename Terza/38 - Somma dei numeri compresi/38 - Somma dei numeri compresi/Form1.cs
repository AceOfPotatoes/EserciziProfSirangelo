using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38___Somma_dei_numeri_compresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt16(txtA.Text);
            int B = Convert.ToInt16(txtB.Text);
            int Somma = 0;
            int K = A;

            if (A < B)
            {
                do
                {
                    Somma += K;
                    K++;
                }
                while (K <= B);

                MessageBox.Show(Somma.ToString());
            }
            else
            {
                MessageBox.Show("A deve essere < di B!!!");
            }
        }
    }
}
