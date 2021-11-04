using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _79___Frase_senza_parola_data_P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsNuovaF_Click(object sender, EventArgs e)
        {
            string F = txtF.Text;
            string P = txtP.Text;            
            int Pos = F.IndexOf(P);
            string FF = F.Substring(0, Pos) + F.Substring(Pos + P.Length);

            MessageBox.Show(FF, "FRASE SENZA PAROLA DATA");


        }
    }
}
