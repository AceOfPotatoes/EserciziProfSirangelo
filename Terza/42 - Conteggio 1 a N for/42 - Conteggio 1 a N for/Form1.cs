using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42___Conteggio_1_a_N_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(txtN.Text);

            for (int K = 1; K <= N; K++)
                MessageBox.Show(K.ToString());
        }
    }
}
