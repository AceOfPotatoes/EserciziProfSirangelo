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

namespace _53___Somma_positivi_e_negativi_in_lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsInizia_Click(object sender, EventArgs e)
        {

            int Dato;
            int SommaP = 0;
            int SommaN = 0;

            do
            {
                Dato = Convert.ToInt32(Interaction.InputBox("Inserisci qui il tuo dato:"));

                if (Dato != 0)

                    if (Dato > 0)
                        SommaP += Dato;

                    else
                        SommaN += Dato;

            } while (Dato != 0);

            lblPos.Text = SommaP.ToString();
            lblNeg.Text = SommaN.ToString();
        }
    }
}
