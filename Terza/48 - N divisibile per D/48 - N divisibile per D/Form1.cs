using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48___N_divisibile_per_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            int D = Convert.ToInt16(txtD.Text);
            int N = Convert.ToInt16(txtN.Text);
            int Z = N;                                              //utilizzata per lasciare N intatto
            byte Div = 0;

            while (Z % D == 0)
            {
                Div++;
                Z /= D; 
            }

            lblN.Text = N.ToString();
            lblD.Text = D.ToString();
            lblDiv.Text = Div.ToString();
        }
    }
}
