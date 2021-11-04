using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55___Gol_segnato_al_minuto_da_giocatore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsAvvisa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Al " + Convert.ToByte(txtMinuto.Text) + "° minuto ha segnato " + txtGiocatore.Text, "AVVISO");
        }
    }
}
