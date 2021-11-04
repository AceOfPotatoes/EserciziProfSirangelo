using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _46___MCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N1 = Convert.ToInt16(txtN1.Text);
            int N2 = Convert.ToInt16(txtN2.Text);
            int S1 = N1;
            int S2 = N2;


            while(S1 != S2)
            {
                if(S1 > S2)
                    S2 += N2;
                else
                    S1 += N1;
            }

            lblMCM.Text = S1.ToString();
        }
    }
}
