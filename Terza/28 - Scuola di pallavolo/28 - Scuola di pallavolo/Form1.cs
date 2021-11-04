using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28___Scuola_di_pallavolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVerifica_Click(object sender, EventArgs e)
        {
            byte E = Convert.ToByte(txtE.Text);
            byte S = Convert.ToByte(txtS.Text);
            bool EtaAccettabile = (E >= 14 && E <= 18);
            bool AbbastanzaAlto = (S >= 165);
            bool Iscrivibile = (EtaAccettabile && AbbastanzaAlto);

            if (Iscrivibile)
                MessageBox.Show("Può essere iscritto/a");
            else
                MessageBox.Show("NON può essere iscritto/a");
        }
    }
}
