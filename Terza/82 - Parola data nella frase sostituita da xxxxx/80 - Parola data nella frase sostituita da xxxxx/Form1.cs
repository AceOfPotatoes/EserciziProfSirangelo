using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _80___Parola_data_nella_frase_sostituita_da_xxxxx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVerifica_Click(object sender, EventArgs e)
        {
            string F = txtF.Text;
            string P = txtP.Text;
            string FF = F.Substring(0, F.IndexOf(P));
            int K = 0;
            int Num = 0;

            while ((K = F.IndexOf(P)) != -1)
            {
                Num++;
                FF += F.Substring(0, K);
                FF += " xxxxx ";
                F = F.Substring(K+P.Length);
            }

            lblFF.Text = FF;
            MessageBox.Show("La tua parola è presente nella frase " +Num.ToString() +" volte", "QUANTE VOLTE");
        }
    }
}
