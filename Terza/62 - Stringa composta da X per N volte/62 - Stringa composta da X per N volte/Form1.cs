using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _62___Stringa_composta_da_X_per_N_volte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsCostruisci_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(txtN.Text);
            string St = "";

            for (int K = 1; K <= N; K++)
                St += "X";


            MessageBox.Show(St);
        }
    }
}
