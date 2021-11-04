using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33___Conteggio_A_B
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
            int K = A;

            if (A < B)
            {
                while (K <= B)
                {
                    MessageBox.Show(K.ToString());
                    K++;
                }
            }
            else
            {
                MessageBox.Show("A deve essere < B");
            }
        }
    }
}
