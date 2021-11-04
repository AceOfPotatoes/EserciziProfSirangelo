using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _65___Da_binario_a_decimale_stringa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Num = Interaction.InputBox("Inserisci qui il tuo numero binario");
            double Somma = 0;          
            double Pos = 0;

            for(int K = Num.Length-1; K >= 0; K--)
            {
                if (Num[K] == '1')
                    Somma += Math.Pow(2, Pos);

                    Pos++;
            }

                
                MessageBox.Show("Il numero binario inserito in decimale equivale a " + Somma.ToString(), "RISULTATO");
        }
    }
}
