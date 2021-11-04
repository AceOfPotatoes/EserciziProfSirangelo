using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36___Conteggio_da_B_ad_A_con_passo_P
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
            int P = Convert.ToInt16(txtP.Text);
            int K = B;

            if(A < B)
            {
                while (K >= A)
                {
                    MessageBox.Show(K.ToString());
                    K -= P;
                }
            }
            else
            {
                MessageBox.Show("A deve essere < di B");
            }
        }
    }
}
