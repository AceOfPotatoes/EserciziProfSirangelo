using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39___Elevazione_a_potenza_intera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(numA.Value);
            int B = Convert.ToInt32(numB.Value);
            int Somma = 1;
            int K = 1;

            if (B == 0)
            {
                Somma = 1;
            }
            else
            {
                do
                {
                    Somma *= A;
                    K++;

                }
                while (K <= B);
            }
            MessageBox.Show(Somma.ToString());
        }
    }
}
