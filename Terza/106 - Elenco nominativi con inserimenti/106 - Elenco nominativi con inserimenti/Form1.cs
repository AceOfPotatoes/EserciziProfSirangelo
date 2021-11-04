using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace _106___Elenco_nominativi_con_inserimenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] VetNominativi;
        int N = 0;
        const int Max = 20;

        private void Form1_Load(object sender, EventArgs e)
        {           
            VetNominativi = new string[Max];
        }

        private void plsInserisci_Click(object sender, EventArgs e)
        {
            if (N < Max)
            {                
                string NuovoDato = txtNominativo.Text;
                if (N != 0)
                {
                    if (NuovoDato != "")
                    {
                        DialogResult Risultato = MessageBox.Show("Vuoi inserire in una determinata posizione?", "ATTENZIONE", MessageBoxButtons.YesNo);
                        if (Risultato == DialogResult.Yes)
                        {
                            int PosIns = int.Parse(Interaction.InputBox("Dammi la posizione (BASE 0)", "ATTENZIONE"));
                            if (PosIns < N)
                            {
                                for (int k = N - 1; k >= PosIns; k--)
                                    VetNominativi[k + 1] = VetNominativi[k];

                                VetNominativi[PosIns] = NuovoDato;
                                N++;
                            }
                            else
                                MessageBox.Show("Posizione maggiore dei limiti del vettore", "ERRORE");
                        }
                        else
                        {
                            VetNominativi[N] = NuovoDato;
                            N++;
                        }
                    }
                    else
                        MessageBox.Show("IL CAMPO DI TESTO E' VUOTO", "ATTENZIONE");
                }
                else
                {
                    VetNominativi[N] = NuovoDato;
                    N++;
                }                
            }
            else
                MessageBox.Show("RAGGIUNTO LIMITE MASSIMO ELEMENTI", "ATTENZIONE");

            txtNominativo.Text = "";
            txtNominativo.Focus();
        }

        private void plsLettera_Click(object sender, EventArgs e)
        {
            string Lettera = txtLettera.Text;
            Lettera = Lettera.ToLower();
            lstNomi.Items.Clear();
            if (Lettera.Length == 1 && char.IsLetter(Lettera[0]))
            {
                for (int k = 0; k <= N - 1; k++)
                    if (Lettera[0] == VetNominativi[k].ToLower()[0])
                        lstNomi.Items.Add(VetNominativi[k]);
            }
            else
                MessageBox.Show("HAI INSERITO PIU' DI UNA LETTERA NELLA TEXTBOX O NON HAI INSERITO LETTERE", "ATTENZIONE");
        }

        private void plsX_Click(object sender, EventArgs e)
        {
            bool TuttiMaggioriX = true;
            int X = int.Parse(txtX.Text);
            for (int k = 0; k <= N - 1; k++)
                if (VetNominativi[k].Length <= X)
                    TuttiMaggioriX = false;
            if (TuttiMaggioriX)
                MessageBox.Show("Tutti gli elementi nel vettore hanno lunghezza maggiore di X", "RISULTATO");
            else
                MessageBox.Show("NON Tutti gli elementi nel vettore hanno lunghezza maggiore di X", "RISULTATO");
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            lstNomi.Items.Clear();
            for (int k = 0; k <= N - 1; k++)
                lstNomi.Items.Add(VetNominativi[k]);
        }

        private void plsPulisci_Click(object sender, EventArgs e)
        {
            Array.Clear(VetNominativi, 0, N);
            lstNomi.Items.Clear();
            N = 0;
        }

        private void plsElimina_Click(object sender, EventArgs e)
        {
            int PosCanc = int.Parse(txtElimina.Text);
            if (PosCanc < N)
            {
                for (int k = PosCanc; k <= N-1; k++)
                    VetNominativi[k] = VetNominativi[k+1];
            }
            else
                MessageBox.Show("Posizione maggiore dei limiti del vettore", "ERRORE");

            N--;
        }
    }
}
