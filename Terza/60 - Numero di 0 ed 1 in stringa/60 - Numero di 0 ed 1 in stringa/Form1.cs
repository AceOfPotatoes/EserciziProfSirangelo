using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _60___Numero_di_0_ed_1_in_stringa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsControlla_Click(object sender, EventArgs e)
        {
            string St = txtStringa.Text;
            byte NumZero = 0;
            byte NumUno = 0;

            for (int K = 0; K <= St.Length - 1; K++)
            {
                if (St[K] == '0')
                    NumZero++;

                else
                    NumUno++;
            }

            MessageBox.Show("Nella tua stringa lo \"0\" è comparso " + NumZero.ToString() + " volte" + " mentre il numero \"1\" è comparso " + NumUno.ToString() +" volte", "Risultato");
        }
    }
}
