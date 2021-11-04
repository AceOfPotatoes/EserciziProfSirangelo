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

namespace _108___Competizione_automobilistica
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        string[] VetPiloti;
        int[] VetTempi;
        int N = 0;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            VetPiloti = new string[25];
            VetTempi = new int[25];
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            if (Nome != "")
            {
                if(!Presente(Nome, N))
                    cmbPiloti.Items.Add(txtNome.Text);
                else
                    MessageBox.Show("Corridore con stesso nome già aggiunto", "ATTENZIONE");
            }               
            else
                MessageBox.Show("Casella di testo vuota!!", "ATTENZIONE");

            txtNome.Text = "";
            txtNome.Focus();
        }

        private void cmbPiloti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Indice = cmbPiloti.SelectedIndex;
            DialogResult Risultato = MessageBox.Show("Il pilota " + cmbPiloti.Items[Indice].ToString() + " ha quindi terminato la prestazione?", "ATTENZIONE", MessageBoxButtons.YesNo);

            if (Risultato == DialogResult.Yes)
            {
                int Tempo = int.Parse(Interaction.InputBox("Scrivi qui il tempo del pilota (SECONDI, INTERO)", "QUAL E' IL TEMPO DEL PILOTA?"));
                               
                VetPiloti[N] = cmbPiloti.Items[Indice].ToString();
                VetTempi[N] = Tempo;
                N++;
            }
            else
                MessageBox.Show("Fai più attenzione, cliccare su cose a caso non porta sempre su strade legittime!!!", "HEY TU");

            cmbPiloti.Items.RemoveAt(Indice);
            Ordina(VetTempi, VetPiloti, N);
            Visualizza(VetTempi, VetPiloti, N);
        }

        private void plsQualifica_Click(object sender, EventArgs e)
        {
            int TempoLimite = 0;
            if (txtTempo.Text == "")
            {
                MessageBox.Show("Casella di testo tempo limite vuota!!!", "ATTENZIONE");
            }
            else
            {
                TempoLimite = int.Parse(txtTempo.Text);

                for (int k = 0; k <= N - 1; k++)
                {
                    if (VetTempi[k] > TempoLimite)
                    {
                        MessageBox.Show("NON tutti i piloti si sono qualificati", "ATTENZIONE");
                        break;
                    }
                    if (k == N - 1)
                    {
                        MessageBox.Show("Tutti i piloti si sono qualificati", "ATTENZIONE");
                    }
                }
            }


        }

        private void plsSqualifica_Click(object sender, EventArgs e)
        {
            int Indice = lstPiloti.SelectedIndex;
            if (Indice != -1)
            {
                int PosCanc = Indice;
                
                for (int k = PosCanc; k <= N - 1; k++)
                {
                    VetPiloti[k] = VetPiloti[k + 1];
                    VetTempi[k] = VetTempi[k + 1];
                }                    
                N--;
            }
            else            
                MessageBox.Show("Nessun pilota selezionato sulla LISTBOX!!", "ATTENZIONE");
            
            Visualizza(VetTempi, VetPiloti, N);
        }

        private void plsSoloQualificati_Click(object sender, EventArgs e)
        {
            int TempoLimite = 0;
            if (txtTempo.Text == "")
            {
                MessageBox.Show("Casella di testo tempo limite vuota!!!", "ATTENZIONE");
            }
            else
            {
                lstPiloti.Items.Clear();
                TempoLimite = int.Parse(txtTempo.Text);
                int Pos = 1;
                for (int k = 0; k <= N - 1; k++)
                {                    
                    if (VetTempi[k] <= TempoLimite)
                    {
                        string Aggiungere = (Pos).ToString() + "° - " + VetPiloti[k] + " - " + VetTempi[k].ToString() + "sec.";
                        lstPiloti.Items.Add(Aggiungere);
                        Pos++;
                    }
                }
            }            
        }

        private void Visualizza(int[] VetTempi, string[] VetPiloti, int N)
        {
            lstPiloti.Items.Clear();
            string Aggiungere = "";
            for (int k = 0; k <= N - 1; k++)
            {
                Aggiungere = (k + 1).ToString() + "° - " + VetPiloti[k] + " - " + VetTempi[k].ToString() + "sec.";
                lstPiloti.Items.Add(Aggiungere);
            }
        }

        private void Ordina(int[] VetTempi, string[] VetPiloti, int N)
        {
            for (int k1 = 0; k1 <= N - 2 && N > 1; k1++)
            {
                int PosMin = k1;

                for (int k2 = k1 + 1; k2 <= N - 1; k2++)
                {
                    if (VetTempi[k2] < VetTempi[PosMin])
                    {
                        PosMin = k2;
                    }
                }
                Scambio(VetTempi, VetPiloti, k1, PosMin);
            }
        }

        private void Scambio(int[] VetTempi, string[] VetPiloti, int k1, int PosMin)
        {
            int Temp1 = VetTempi[k1];
            string Temp2 = VetPiloti[k1];
            VetTempi[k1] = VetTempi[PosMin];
            VetPiloti[k1] = VetPiloti[PosMin];
            VetTempi[PosMin] = Temp1;
            VetPiloti[PosMin] = Temp2;
        }        

        private bool Presente(string Nome, int N)
        {
            for (int k = 0; k<=cmbPiloti.Items.Count-1 && cmbPiloti.Items.Count>0; k++)
            {
                string Elemento = cmbPiloti.Items[k].ToString();
                if(Elemento == Nome)
                    return true;
            }
            return false;
        }
    }
}
