using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _109___Ordinamento_e_ricerca_nominativi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] VetDisordinato;
        string[] VetOrdinato;
        int N = 0;
        const int Max = 30;

        private void Form1_Load(object sender, EventArgs e)
        {           
            VetDisordinato = new string[Max];
            VetOrdinato = new string[Max];
        }

        private void plsInserisci_Click(object sender, EventArgs e)
        {           
            if (N < Max)
            {
                string ins = txtNome.Text;
                VetDisordinato[N] = ins;
                lstDisordinata.Items.Add(ins);
                N++;
            }
            else
                MessageBox.Show("Hai raggiunto il limite massimo di nominativi", "ATTENZIONE");

            txtNome.Text = "";
            txtNome.Focus();
        }

        private void plsOrdina_Click(object sender, EventArgs e)
        {
            lstOrdinata.Items.Clear();
            VetOrdinato = VetDisordinato;
            for (int k1 = 0; k1 <= N - 2; k1++)
            {
                int PosMin = k1;
                for (int k2 = k1+1; k2 <= N - 1; k2++)
                {
                    if (string.Compare(VetOrdinato[k2], VetOrdinato[PosMin]) < 0)
                    {
                        PosMin = k2;
                    }
                }
                string Temp = VetOrdinato[k1];
                VetOrdinato[k1] = VetOrdinato[PosMin];
                VetOrdinato[PosMin] = Temp;
            }

            for(int i = 0; i <= lstDisordinata.Items.Count-1; i++)
            {
                lstOrdinata.Items.Add(VetOrdinato[i]);
            }
        }

        private void plsRicerca_Click(object sender, EventArgs e)
        {
            int Inizio = 0;
            int Fine = N;
            int Pos = -1;
            int K = 0;
            string Dato = txtNome.Text;

            while((Pos==-1) && (Inizio <= Fine))
            {
                int Centro = (Inizio + Fine) / 2;
                if (Dato == VetOrdinato[Centro])
                    Pos = Centro;
                else
                {
                    if (string.Compare(Dato, VetOrdinato[Centro]) < 0)
                        Fine = Centro - 1;
                    else
                        Inizio = Centro + 1;
                }
                K++;
            }

            if (Pos == -1)
                MessageBox.Show("L'ELEMENTO NON E' PRESENTE NEL VETTORE", "ATTENZIONE");
            else
            {
                MessageBox.Show("L'ELEMENTO SI TROVA IN POSIZIONE "+Pos.ToString()+". ADESSO VERRA' EVIDENZIATO", "ECCO LA POSIZIONE");
                lstOrdinata.SelectedIndex = Pos;
            }
        }

    }
}
