using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _79___Verifica_se_ciao_IndexOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVerifica_Click(object sender, EventArgs e)
        {
            string Frase = txtFrase.Text;

            if (Frase.IndexOf("ciao") == -1)
                MessageBox.Show("Nella frase NON è presente la parola ciao (minuscolo)", "RISULTATO VERIFICA");
            else
                MessageBox.Show("Nella frase è presente la parola ciao (minuscolo)", "RISULTATO VERIFICA");
        }
    }
}
