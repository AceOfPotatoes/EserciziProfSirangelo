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

namespace _59___Carattere_nella_frase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsStart_Click(object sender, EventArgs e)
        {
            string Str = Interaction.InputBox("Inserisci qui la tua frase");
            char Car = Convert.ToChar(Interaction.InputBox("Dammi il carattere del quale vuoi effettuare la scansione"));
            int NumCar = 0;

            for (int K = 0; K <= Str.Length - 1; K++)
                if (Str[K] == Car)
                    NumCar++;

            if (NumCar == 1)
                MessageBox.Show("Il tuo carattere è scritto nella frase 1 volta");
            else
                MessageBox.Show("Il tuo carattere è scritto nella frase " + NumCar.ToString() +" volte", "Risultato");
        }
    }
}
