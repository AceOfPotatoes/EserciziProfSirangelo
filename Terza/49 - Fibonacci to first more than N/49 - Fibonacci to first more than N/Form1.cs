using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49___Fibonacci_to_first_more_than_N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            int Primo = 0;
            int Secondo = 1;
            int Vis = 0;
            int N = Convert.ToInt32(txtN.Text);

            MessageBox.Show("1");

            while (Vis <= N)
            {
                Vis = Primo + Secondo;
                Primo = Secondo;
                Secondo = Vis;

                MessageBox.Show(Vis.ToString());
            }
        }
    }
}
