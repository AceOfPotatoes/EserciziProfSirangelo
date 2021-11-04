using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43___Tabellina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(numN.Value);

            for (int K = N; K <= (N * 10); K += N)
                MessageBox.Show(K.ToString());
        }
    }
}
