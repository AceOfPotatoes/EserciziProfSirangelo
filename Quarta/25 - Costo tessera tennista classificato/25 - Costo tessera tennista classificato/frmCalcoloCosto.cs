using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25___Costo_tessera_tennista_classificato
{
    public partial class frmCalcoloCosto : Form
    {
        public frmCalcoloCosto()
        {
            InitializeComponent();
        }

        Tennista mioTennista;
        Classificato mioTennistaClassificato;
        bool èClassificato = false;

        private void frmCalcoloCosto_Load(object sender, EventArgs e)
        {            
            ControlloTennistaClassificato();
            Regione.CreaComboBoxRegioni(cmbRegione);
            cmbPreferenzaManuale.Items.Add("MANCINO");
            cmbPreferenzaManuale.Items.Add("DESTRO");
        }

        private void ControlloTennistaClassificato()
        {
            var Risultato = MessageBox.Show("Il tennista è classificato?", "Attenzione!!!", MessageBoxButtons.YesNo);
            if (Risultato == DialogResult.Yes)
            {
                lblCategoria.Visible = true;
                lblNumIscrizione.Visible = true;
                numCategoria.Visible = true;
                numIscrizione.Visible = true;
                lblIscrizione2.Visible = true;
                lblCategoria2.Visible = true;
                èClassificato = true;
            }
            else
                èClassificato = false;
            
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            bool PreferenzaManuale = ImpostaPreferenzaManuale();
            if (èClassificato)
            {
                mioTennistaClassificato = new Classificato(txtNome.Text, PreferenzaManuale, (string)cmbRegione.Items[cmbRegione.SelectedIndex], (int)numCategoria.Value, (int)numIscrizione.Value);
                mioTennistaClassificato.VisualizzaDatiTennista(lblNome, lblRegione, lblPrefMan, lblCat, lblIscr);
                mioTennistaClassificato.CalcolaEVisualizzaContributo(lblCostoTessera);
            }
            else
            {
                mioTennista = new Tennista(txtNome.Text, PreferenzaManuale, (string)cmbRegione.Items[cmbRegione.SelectedIndex]);
                mioTennista.VisualizzaDatiTennista(lblNome, lblRegione, lblPrefMan, lblCat, lblIscr);
                mioTennista.CalcolaEVisualizzaContributo(lblCostoTessera);
            }
                


        }

        private bool ImpostaPreferenzaManuale()
        {
            return ((string)cmbPreferenzaManuale.Items[cmbPreferenzaManuale.SelectedIndex] == "DESTRO");
        }
    }
}
