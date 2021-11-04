using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22___Calcolatrice_semplice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(txtR1.Text);
            double R2 = Convert.ToDouble(txtR2.Text);
            double Ris;
            int P = Convert.ToInt16(txtP.Text);

            switch (P)
            {
                case 1:
                    Ris = R1 + R2;
                    lblRis.Text = Ris.ToString();
                    break;

                case 2:
                    Ris = R1 - R2;
                    lblRis.Text = Ris.ToString();
                    break;

                case 3:
                    Ris = R1 * R2;
                    lblRis.Text = Ris.ToString();
                    break;

                case 4:
                    Ris = R1 / R2;
                    lblRis.Text = Ris.ToString();
                    break;

                default:
                    MessageBox.Show("INSERIRE VALORE VALIDO IN P");
                    break;

            }
        }
    }
}
