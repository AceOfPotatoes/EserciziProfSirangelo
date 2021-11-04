using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47___Raddoppio_N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(txtN.Text);
            int Max = Convert.ToInt16(txtMax.Text);

            while (N <= Max)
            {
                N *= 2;
                MessageBox.Show(N.ToString());
            }
        }
    }
}
