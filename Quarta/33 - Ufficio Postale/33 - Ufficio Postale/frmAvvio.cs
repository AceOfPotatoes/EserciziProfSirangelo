using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33___Ufficio_Postale
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        private void plsPaga_Click(object sender, EventArgs e)
        {
            double ImportoDaVersare = Convert.ToDouble(txtImporto.Text);
            lblDaVersare.Text = txtImporto.Text+"€";
            frmVersamentoBanconote Form2 = new frmVersamentoBanconote();
            Form2.ShowDialog();
            double ImportoVersato = Form2.TotaleVersato();
            lblVersato.Text = ImportoVersato.ToString()+"€";

            if (ImportoDaVersare == Math.Round(ImportoVersato, 2))
                lblRisultatoVerifica.Text = "SOLDI VERSATI CORRETTI";
            else
                lblRisultatoVerifica.Text = "SOLDI VERSATI NON CORRETTI";            
        }
    }
}
