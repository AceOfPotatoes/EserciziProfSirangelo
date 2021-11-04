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

namespace _50___Somma_di_lista
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

        private void button1_Click(object sender, EventArgs e)
        {
            int Dato = 0;
            int Somma = 0;

            do
            {
                Dato = Convert.ToInt32(Interaction.InputBox("Inserisci qui il tuo dato:"));

                if (Dato != 0)
                {
                    Somma += Dato;
                }

            } while (Dato != 0);

            lblSomma.Text = Somma.ToString();
        }
    }
}
