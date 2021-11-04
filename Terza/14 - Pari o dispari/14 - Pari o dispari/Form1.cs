using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14___Pari_o_dispari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVerifica_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(txtN.Text);

            if (N % 2 == 0)
            {
                MessageBox.Show("Il numero inserito è pari");
            }
            else
            {
                MessageBox.Show("Il numero inserito è dispari");
            }
        }
    }
}
