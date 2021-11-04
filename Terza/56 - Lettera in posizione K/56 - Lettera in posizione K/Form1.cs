using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _56___Lettera_in_posizione_K
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string St = txtStr.Text;
            byte K = Convert.ToByte(txtPos.Text);

            if (K > St.Length-1)
                MessageBox.Show("Non c'è nessuna cifra nella posizione scelta", "ERRORE!!!");
            else
                MessageBox.Show(St[K].ToString());           
        }
    }
}
