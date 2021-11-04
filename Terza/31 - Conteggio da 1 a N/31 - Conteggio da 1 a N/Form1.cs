using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31___Conteggio_da_1_a_N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsConta_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(txtN.Text);
            int K = 1;

            while (K <= N)
            {
                MessageBox.Show(K.ToString());
                K++;
            }
        }
    }
}
