using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _84___Prezzo_reale_di_vendita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            int P1 = Convert.ToInt32(txtP1.Text);
            int P2 = Convert.ToInt32(txtP2.Text);
            int S1 = Convert.ToInt32(txtS1.Text);
            int S2 = Convert.ToInt32(txtS2.Text);
            int P1Fin = PrezzoComplessivo(P1, S1);
            int P2Fin = PrezzoComplessivo(P2, S2);


            lblPap.Text = P1Fin.ToString();
            lblTop.Text = P2Fin.ToString();

            if (P1Fin < P2Fin)
            {
                MessageBox.Show("Lo store più conveniente è quello di Paperino");
            }
            else
            {
                MessageBox.Show("Lo store più conveniente è quello di Topolino");
            }
        }

        private int PrezzoComplessivo(int P, int S)
        {
            int fine = P - (P / 100) * S;
            return fine;
        }
    }
}
