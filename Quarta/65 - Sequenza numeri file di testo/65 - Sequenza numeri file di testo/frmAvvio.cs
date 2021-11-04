using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.IO;
using System.Windows.Forms;

namespace _65___Sequenza_numeri_file_di_testo
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        StreamWriter FW;
        StreamReader FR;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            FW = File.CreateText("Dati.txt");
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            int N = (int)numN.Value;
            FW.WriteLine(N);
        }

        private void plsTermina_Click(object sender, EventArgs e)
        {
            FW.Close();
            numN.Enabled = false;
            plsAggiungi.Enabled = false;
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            lstNumeri.Items.Clear();
            FR = File.OpenText("Dati.txt");

            while (!FR.EndOfStream)
                lstNumeri.Items.Add(FR.ReadLine());

            FR.Close();
        }

        private void plsMedia_Click(object sender, EventArgs e)
        {
            int Somma = 0;
            FR = File.OpenText("Dati.txt");
            byte N = 0;

            while (!FR.EndOfStream)
            {
                Somma += int.Parse(FR.ReadLine());
                N++;
            }


            MessageBox.Show("La media aritmetica di tutti gli elementi è: " + Somma / N);
            FR.Close();
        }

        private void plsVerifica_Click(object sender, EventArgs e)
        {
            int Verifica = Convert.ToInt32(Interaction.InputBox("SCRIVI IL NUMERO SU CUI SVOLGERE LE VERIFICHE"));
            FR = File.OpenText("Dati.txt");
            byte N = 0;
            bool Presente = false;

            while (!FR.EndOfStream)
            {
                if (Verifica == int.Parse(FR.ReadLine()))
                {
                    Presente = true;
                    break;
                }
                    
                N++;
            }

            if (Presente)
                MessageBox.Show("Il numero è presente e si trova in posizione: " + N, "NUMERO TROVATO");
            else
                MessageBox.Show("Il numero NON è presente", "NUMERO NON TROVATO");
        }
    }
}
