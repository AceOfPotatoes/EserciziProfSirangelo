using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace _26___Prodotti__penne
{
    public partial class frmProdotti : Form
    {
        public frmProdotti()
        {
            InitializeComponent();
        }

        Penna miaPenna;

        private void rbNormale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormale.Checked)
                rbScatto.Checked = false;
            else
                rbScatto.Checked = true;

        }

        private void rbScatto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbScatto.Checked)
                rbNormale.Checked = false;
            else
                rbNormale.Checked = true;
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            if(rbNormale.Checked)
                miaPenna = new Penna((int)numCodice.Value, rtxtDescrizione.Text, (int)numPrezzoDiListino.Value, txtColore.Text, false, (int)numPenne.Value);
            else
            {
                miaPenna = new Penna((int)numCodice.Value, rtxtDescrizione.Text, (int)numPrezzoDiListino.Value, txtColore.Text, true, (int)numPenne.Value);
                miaPenna.ScontoScatto = Convert.ToInt32(Interaction.InputBox("Inserire qui lo sconto da applicare alle penne a scatto:"));
            }

            miaPenna.VisualizzaValoriForm(lblCodice, lblPrezzoListino, lblScatto, lblColore, lblNumeroPenne, lblPrezzoSingolaPenna, lblDescrizione);                
        }
    }
}
