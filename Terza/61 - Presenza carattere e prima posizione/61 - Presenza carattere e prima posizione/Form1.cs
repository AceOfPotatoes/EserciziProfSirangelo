using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.VisualBasic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _61___Presenza_carattere_e_prima_posizione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsStart_Click(object sender, EventArgs e)
        {
            string St = Interaction.InputBox("Inserisci qui la tua frase");
            char Car = Convert.ToChar(Interaction.InputBox("Ora invece dammi il carattere sul quale devo effettuare il controllo"));
            int Pos = -1;
            int K = 0;

            while(K >= St.Length-1 || !(St[K] == Car))
            {
                K++;
            }

            Pos = K;

            if (Pos < 0)
                MessageBox.Show("Il carattere non è presente all'interno della frase");
            else
                MessageBox.Show("Il carattere è presente e si trova nella posizione numero " + Pos.ToString());


        }
    }
}
