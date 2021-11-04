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

namespace _51___Maggiori_di_10_in_lista_di_N_numeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(Interaction.InputBox("Inserisci N (numero di dati nella lista):"));
            int Dato;
            int Maggiori = 0;

            for(int K = 1; K <= N; K++)
            {
                Dato = Convert.ToInt32(Interaction.InputBox("Inserisci il tuo dato qui:"));

                if(Dato > 10)                
                    Maggiori++;               
            }

            lblRis.Text = Maggiori.ToString();
        }
    }
}
