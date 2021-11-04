using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18___Somma_reali_positivi
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

            if(R1 < 0)
            {
                R1 = -R1;
            }

            if(R2 < 0)
            {
                R2 = -R2;
            }

            Ris = R1 + R2;
            lblRis.Text = Ris.ToString();
        }
    }
}
