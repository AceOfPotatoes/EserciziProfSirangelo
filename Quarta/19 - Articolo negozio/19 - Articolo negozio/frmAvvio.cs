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

namespace _19___Articolo_negozio
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        Articolo mioArticolo;

        private void frmAvvio_Load(object sender, EventArgs e)
        {            
        }

        private void plsCreaArticolo_Click(object sender, EventArgs e)
        {
            this.Size = new Size(559, 337);
            int prezlist = int.Parse(txtPrezList.Text);
            int sconto = int.Parse(txtSconto.Text);
            int pezzdisp = int.Parse(txtQuantità.Text);
            string desc = txtDescrizione.Text;
            mioArticolo = new Articolo(prezlist, sconto, pezzdisp, desc); 
            CambiaVisibità();
            AggiornaStatistiche();
        }

        private void CambiaVisibità()
        {
            lblDescrizione.Visible = true;
            lblListino.Visible = true;
            lblQuantità.Visible = true;
            lblRicavoSvendita.Visible = true;
            lblSconto.Visible = true;
            txtDescrizione.Visible = false;
            txtPrezList.Visible = false;
            txtQuantità.Visible = false;
            txtSconto.Visible = false;
            plsCreaArticolo.Visible = false;
        }

        private void plsAumentaPezzi_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt16(Interaction.InputBox("Quanti pezzi vuoi aggiungere al magazzino?"));
            mioArticolo.AumentaPezzi(N);
            AggiornaStatistiche();
        }

        private void plsModificaSconto_Click(object sender, EventArgs e)
        {
            int NuovoSconto = Convert.ToInt16(Interaction.InputBox("Inserire nuova percentuale di sconto"));
            mioArticolo.Sconto = NuovoSconto;
            AggiornaStatistiche();
        }

        private void AggiornaStatistiche()
        {
            lblDescrizione.Text = mioArticolo.Descrizione;
            lblListino.Text = mioArticolo.PrezzoListino.ToString()+"€";
            lblPrezzoReale.Text = mioArticolo.PrezzoVendita.ToString()+"€";
            lblQuantità.Text = mioArticolo.PezziDisponibili.ToString();
            lblRicavoSvendita.Text = mioArticolo.CalcolaRicavoSvendita().ToString() + "€";
            lblSconto.Text = mioArticolo.Sconto.ToString() + "%";
        }

    }
}
