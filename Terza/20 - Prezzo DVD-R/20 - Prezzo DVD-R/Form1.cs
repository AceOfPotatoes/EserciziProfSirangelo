using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            int P = Convert.ToInt16(txtP.Text);
            int H = Convert.ToInt16(txtH.Text);
            int Q = Convert.ToInt16(txtQ.Text);
            int S1 = Convert.ToInt16(txtS1.Text);
            int S2 = Convert.ToInt16(txtS2.Text);
            double Inter;
            double PC;

            if (Q > 100 && Q <= 200)
            {
                Inter = P - (P * S1) / 100;
                PC = Inter;

                if (H < 30)
                {
                    PC = Inter - (Inter * 10) / 100;
                }

                PC = (PC * Q) / 100;
                lblPC.Text = PC.ToString();

            }
            else
            {
                if (Q > 200)
                {
                   Inter = P - (P * S2) / 100;
                   PC = Inter;

                    if (H < 30)
                    {
                        PC = Inter - (Inter * 10) / 100;
                    }

                    PC = (PC * Q) / 100;
                    lblPC.Text = PC.ToString();
                }
                else
                {
                    if (H < 30)
                    {
                        PC = P - (P * 10) / 100;
                    }
                    else
                    {
                        PC = P;
                    }

                    PC = (PC * Q) / 100;
                    lblPC.Text = PC.ToString();
                }

            }
        }
    }
}

