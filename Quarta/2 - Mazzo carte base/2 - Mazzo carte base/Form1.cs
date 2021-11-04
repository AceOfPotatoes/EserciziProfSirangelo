using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace _2___Mazzo_carte_base
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        string[] Vet;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            Vet = new string[10];
        }

        private void plsInizia_Click(object sender, EventArgs e)
        {
            Inserisci();
           
        }

        private void Inserisci()
        {
            string DaInserire = "";
            bool Presente = false;
            for (int k = 0; k < 10; k++)
            {
                DaInserire = Interaction.InputBox("Inserire una carta").ToUpper();
                Presente = false;

                for(int j = 0; j < 10; j++)
                {
                    if (DaInserire == Vet[j])
                        Presente = true;
                }
                if (!Presente)                
                    Vet[k] = DaInserire;
                else
                {
                    MessageBox.Show("LA CARTA INSERITA E' GIA' PRESENTE", "ATTENZIONE!");
                    k--;
                }                            
                Visualizza(k);
            }
        }

        private void Visualizza(int k)
        {
            lstCarte.Items.Clear();

            for(int j = 0; j <= k && j<10; j++)            
                lstCarte.Items.Add(Vet[j]);            
        }

        private void plsAssi_Click(object sender, EventArgs e)
        {
            int Assi = 0;
            for(int k = 0; k < 10; k++)
            {
                if (Vet[k][0] == 'A')
                    Assi++;
            }

            if(Assi == 1)
                MessageBox.Show("All'interno del vettore è presente " + Assi.ToString() + " asso", "Calcolo Assi");
            else
                MessageBox.Show("All'interno del vettore sono presenti " + Assi.ToString() + " assi", "Calcolo Assi");
        }
    }
}
