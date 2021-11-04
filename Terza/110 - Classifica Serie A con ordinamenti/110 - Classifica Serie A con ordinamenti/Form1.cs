using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _110___Classifica_Serie_A_con_ordinamenti
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        string[] VetNomi;
        int[] VetPunteggi;
        int N = 0;
        const int Max = 20;
        bool FineInput = false;
        bool Ordinato = false;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            VetNomi = new string[Max];
            VetPunteggi = new int[Max];
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            if (FineInput)
                MessageBox.Show("INPUT TERMINATO, RIAVVIARE IL SOFTWARE", "ATTENZIONE");
            else
            {
                if (N < Max)
                {
                    if (txtNome.Text != "")
                        VetNomi[N] = txtNome.Text;
                    else
                        MessageBox.Show("Inserire un nome per la squadra", "ERRORE");

                    if (txtPunteggio.Text != "")
                        VetPunteggi[N] = Convert.ToInt32(txtPunteggio.Text);
                    else
                        MessageBox.Show("Inserire un punteggio per la squadra", "ERRORE");
                }
                N++;
                txtNome.Text = "";
                txtPunteggio.Text = "";
                txtNome.Focus();
            }           
        }

        private void plsNome_Click(object sender, EventArgs e)
        {
            FineInput = true;
            for(int k1 = 0; k1 <= N - 2; k1++)
            {
                int PosMin = k1;
                for(int k2 = k1 + 1; k2 <= N - 1; k2++)
                {
                    if (string.Compare(VetNomi[PosMin], VetNomi[k2], true) > 0)
                        PosMin = k2;
                }
                string Temp1 = VetNomi[k1];
                int Temp2 = VetPunteggi[k1];
                VetNomi[k1] = VetNomi[PosMin];
                VetPunteggi[k1] = VetPunteggi[PosMin];
                VetNomi[PosMin] = Temp1;
                VetPunteggi[PosMin] = Temp2;
            }

            lstSquadre.Items.Clear();
            for(int i = 0; i <= N-1; i++)
            {
                lstSquadre.Items.Add(VetNomi[i] + " - " + VetPunteggi[i]);
            }
        }

        private void plsPunteggio_Click(object sender, EventArgs e)
        {
            FineInput = true;
            Ordinato = true;
            for (int k1 = 0; k1 <= N - 2; k1++)
            {
                int PosMin = k1;
                for (int k2 = k1 + 1; k2 <= N - 1; k2++)
                {
                    if (VetPunteggi[k2]<VetPunteggi[PosMin])
                        PosMin = k2;
                }
                string Temp1 = VetNomi[k1];
                int Temp2 = VetPunteggi[k1];
                VetNomi[k1] = VetNomi[PosMin];
                VetPunteggi[k1] = VetPunteggi[PosMin];
                VetNomi[PosMin] = Temp1;
                VetPunteggi[PosMin] = Temp2;
            }

            int[] VetTemp1 = new int[Max];
            string[] VetTemp2 = new string[Max];
            int j = N - 1;
            for (int k = 0; k <= N - 1; k++)
            {
                VetTemp1[k] = VetPunteggi[j];
                VetTemp2[k] = VetNomi[j];
                j--;
            }
            VetPunteggi = VetTemp1;

            lstSquadre.Items.Clear();
            for (int i = 0; i <= N-1; i++)           
                lstSquadre.Items.Add(VetNomi[i] + " - " + VetPunteggi[i]);
            
        }

        private void plsControlla_Click(object sender, EventArgs e)
        { 
            int Pos;
            if (Ordinato)
            {
                Pos = Posizione(VetPunteggi, N);
                MessageBox.Show("Se una squadra avesse il seguente punteggio sarebbe in " + Pos.ToString() + "° posizione", "ECCO LA POSIZIONE IPOTETICA");
            }               
            else
                MessageBox.Show("L'elenco deve ancora essere ordinato per punteggio", "ATTENZIONE");

        }

        private int Posizione(int[] VetPunteggi, int N)
        {
            
            int Inizio = 0;
            int Fine = N-1;
            int Dato = Convert.ToInt32(txtControlla.Text);
            int Centro = 0;
            while (Inizio <= Fine)
            {
                Centro = (Inizio + Fine) / 2;
                if (Dato > VetPunteggi[Centro])
                    Fine = Centro - 1;
                else
                    Inizio = Centro + 1; 
            }
            return Inizio+1;
        }
    }
}
