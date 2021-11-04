using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32___Ciao_a_tutti_per_N_volte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsSaluta_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(txtN.Text);
            int K = 1;

            while (K <= N)
            {
                MessageBox.Show("CIAO A TUTTI!");
                K++;
            }
        }
    }
}
