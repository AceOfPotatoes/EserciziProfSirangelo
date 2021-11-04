using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14___Punti_piano_cartesiano
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        Punto P1;
        Punto P2;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            P1 = new Punto();
            P2 = new Punto();
        }

        private void plsDistanza_Click(object sender, EventArgs e)
        {
            CambiaProprietà();
            MessageBox.Show("La distanza fra il Punto A e il Punto B è " + Math.Round(P1.Distanza(P2), 2), "CALCOLO DISTANZA");
        }

        private void plsQuadrante_Click(object sender, EventArgs e)
        {
            CambiaProprietà();
            if (P1.StessoQuadrante(P2))
                MessageBox.Show("I due punti si trovano nello stesso quadrante", "RISULTATO");
            else
                MessageBox.Show("I due punti NON si trovano nello stesso quadrante", "RISULTATO");

        }

        private void plsPerimetro_Click(object sender, EventArgs e)
        {
            CambiaProprietà();
            MessageBox.Show("Il perimetro del triangolo O-PA-PB è " + Math.Round(P1.PerimetroConOrigineE(P2), 3), "RISULTATO PERIMETRO");
        }

        private void plsCerchio_Click(object sender, EventArgs e)
        {
            CambiaProprietà();
            int Raggio = int.Parse(Interaction.InputBox("INSERIRE RAGGIO CERCHIO", "ATTENZIONE"));

            if (P1.DentroCerchio(Raggio, P2))
                MessageBox.Show("I DUE PUNTI CADONO NEL CERCHIO DI RAGGIO INDICATO", "ATTENZIONE");
            else
                MessageBox.Show("I DUE PUNTI NON CADONO NEL CERCHIO DI RAGGIO INDICATO", "ATTENZIONE");
        }

        private void CambiaProprietà()
        {
            P1.X = Convert.ToInt16(numX1.Value);
            P1.Y = Convert.ToInt16(numY1.Value);
            P2.X = Convert.ToInt16(numX2.Value);
            P2.Y = Convert.ToInt16(numY2.Value);
        }

    }
}
