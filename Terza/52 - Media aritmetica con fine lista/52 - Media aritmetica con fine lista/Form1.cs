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

namespace _52___Media_aritmetica_con_fine_lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plsInizia_Click(object sender, EventArgs e)
        {
            double Dato;
            double Somma = 0;
            double Media = 0;
            double K = 0;

            do
            {
                Dato = Convert.ToDouble(Interaction.InputBox("Inserisci qui il tuo dato (reale positivo)"));

                if (Dato < 0)
                    MessageBox.Show("Il dato deve essere > 0");

                if (Dato != 0)
                {
                    Somma += Dato;
                    K++;
                }
            } while (Dato != 0);

            Media += Somma / K;
            lblMedia.Text = Convert.ToString(Math.Round(Media ,2));

        }
    }
}
