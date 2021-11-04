using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27___Superamento_esame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Prova di utilizzo NumericUpDown

            byte V1 = Convert.ToByte(numV1.Value);
            byte V2 = Convert.ToByte(numV2.Value);
            int M = (V1 + V2) / 2;

            if(V1 >= 8 || M >= 6)
            {
                MessageBox.Show("Il candidato ha superato l'esame");
            }
            else
            {
                MessageBox.Show("Il candidato NON ha superato l'esame");
            }

        }
    }
}
