using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4___Nominativi_e_ListBox
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        string[] Nominativi;
        int N = 0;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            Nominativi = new string[30];
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            string DaAggiungere = txtAggiungere.Text.ToUpper();
            AggiungiDatoAlVettore(DaAggiungere);
            txtAggiungere.Clear();
            txtAggiungere.Focus();
        }

        private void AggiungiDatoAlVettore(string DaAggiungere)
        {
            if (DaAggiungere != "")
            {
                Nominativi[N] = DaAggiungere;
                N++;
            }
            else
                MessageBox.Show("CAMPO NOMINATIVO VUOTO", "ATTENZIONE");

            CopiaVettoreInListBox();
        }

        private void CopiaVettoreInListBox()
        {
            lstNominativi.Items.Clear();
            for(int k = 0; k < N; k++)            
                lstNominativi.Items.Add(Nominativi[k]);            
        }

        private void plsCerca_Click(object sender, EventArgs e)
        {
            string DaCercare = txtCercare.Text.ToUpper();
            int Pos = TrovaPosizione(DaCercare);
            if (Pos != -1)
                MessageBox.Show("Il nominativo si trova nella posizione " + Pos, "RISULTATO RICERCA");
            else
                MessageBox.Show("Il nominativo ricercato non si trova all'interno del vettore", "RISULTATO RICERCA");

            txtCercare.Clear();
            txtCercare.Focus();
            
        }

        private int TrovaPosizione(string DaCercare)
        {
            int Pos = -1;
            for(int k = 0; k < N; k++)
            {
                if (DaCercare == Nominativi[k])
                {
                    lstNominativi.SelectedIndex = k;
                    Pos = k;
                    return Pos;
                }                    
            }
            return Pos;
        }
    }
}
