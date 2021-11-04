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

namespace _107___Scala_40
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        string[] VetCarte;
        int N = 0;
        
        private void frmAvvio_Load(object sender, EventArgs e)
        {
            VetCarte = new string[13];
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            string Carta = txtCarta.Text;
            if (Carta.Length == 2)
            {
                if (N == 0)
                {
                    VetCarte[N] = Carta;
                    N++;
                }
                else
                {
                    bool Presente = false;
                    for (int k = 0; k <= N - 1; k++)
                    {
                        if (VetCarte[k] == Carta)
                        {
                            Presente = true;
                            break;
                        }
                    }

                    if (!Presente)
                    {
                        int PosIns = int.Parse(Interaction.InputBox("IN CHE POSIZIONE VUOI INSERIRE QUESTA CARTA?", "ATTENZIONE"));
                        if (PosIns < N)
                        {
                            for (int k = N - 1; k >= PosIns; k--)
                                VetCarte[k + 1] = VetCarte[k];

                            VetCarte[PosIns] = Carta;
                            N++;
                        }
                        else
                            MessageBox.Show("Posizione maggiore dei limiti del vettore", "ERRORE");
                    }
                    else
                        MessageBox.Show("La carta è già presente all'interno del vettore", "ATTENZIONE");
                }
                if (N == 13)
                    plsScarta.Visible = true;
                txtCarta.Text = "";
                txtCarta.Focus();
                Visualizza(VetCarte, N);
            }
            else
                MessageBox.Show("LUNGHEZZA STRINGA SCORRETTA, RIPROVARE", "ATTENZIONE");            
        }

        private void plsScarta_Click(object sender, EventArgs e)
        {
            int PosCanc = int.Parse(Interaction.InputBox("INSERISCI LA POSIZIONE DELL'ELEMENTO CHE VUOI CANCELLARE"));
            if (PosCanc < N)
            {
                for (int k = PosCanc; k <= N - 1; k++)
                    VetCarte[k] = VetCarte[k + 1];
            }
            else
                MessageBox.Show("Posizione maggiore dei limiti del vettore", "ERRORE");
            N--;

            Visualizza(VetCarte, N);
        }


        private void plsPalo_Click(object sender, EventArgs e)
        {
            bool StessoPalo = false;
            char Palo = VetCarte[0][1];
            int NumCartePalo = 0;
            for (int k = 1; k<=N-1; k++)
            {
                if (VetCarte[k][1] != Palo)
                    break;
                else
                    NumCartePalo++;                
            }
            if (NumCartePalo == N)
                StessoPalo = true;

            if (StessoPalo)
                MessageBox.Show("TUTTI GLI ELEMENTI DEL VETTORE SONO DELLO PALO", "ATTENZIONE");
            else
                MessageBox.Show("NON TUTTI GLI ELEMENTI DEL VETTORE SONO DELLO PALO", "ATTENZIONE");
        }

        private void plsChiuso_Click(object sender, EventArgs e)
        {
            char Carta = Convert.ToChar(Interaction.InputBox("Dammi il carattere identificativo della carta da controllare"));
            int NumCarte = 0;
            bool Chiusura = false;

            for (int k = 0; k <= N - 1; k++)
                if (Carta == VetCarte[k][0])
                    NumCarte++;
            if (NumCarte == 3)
                Chiusura = true;

            if (Chiusura)
                MessageBox.Show("Hai chiuso!!!", "COMPLIMENTI");
            else
                MessageBox.Show("Ancora non hai chiuso!!!", "MI DISPIACE");
        }

        private void Visualizza(string[] VetCarte, int N)
        {
            lstCarte.Items.Clear();
            for (int k = 0; k <= N - 1; k++)
                lstCarte.Items.Add(VetCarte[k]);
        }
    }
}
