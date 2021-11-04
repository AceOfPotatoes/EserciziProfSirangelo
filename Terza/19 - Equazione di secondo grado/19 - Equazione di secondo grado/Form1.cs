using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19___Equazione_di_secondo_grado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsRisolvi_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt16(txtA.Text);
            int B = Convert.ToInt16(txtB.Text);
            int C = Convert.ToInt16(txtC.Text);
            int Delta;
            double X1;
            double X2;

            Delta = (B * B) - ((4 * A * C));

            if (Delta < 0)
            {
                MessageBox.Show("Non esiste nessuna soluzione in R");
            }
            else
            {
                if (Delta == 0)
                {
                    MessageBox.Show("Ci sono due soluzioni reali e coincidenti");
                    X1 = -B / (2*A);
                    X2 = X1;
                }
                else
                {
                    MessageBox.Show("Ci sono due soluzioni reali e distinte");
                    X1 = (-B + Math.Sqrt(Delta)) / (2*A);
                    X2 = (-B - Math.Sqrt(Delta)) / (2*A);
                }

                lblX1.Text = X1.ToString();
                lblX2.Text = X2.ToString();


            }

        }
    }
}
