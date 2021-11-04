using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _105___Lancio_del_disco
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        int Pos = 0;
        string[] VetNomi;
        int[] VetMisure;
        int somma;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            VetNomi = new string[15];
            VetMisure = new int[15];
        }


        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            if (Pos < 14)
            {
                VetNomi[Pos] = txtAtleta.Text;
                int lancio = int.Parse(Interaction.InputBox("DAMMI LA MISURA IN METRI NEL LANCIO"));
                VetMisure[Pos] = lancio;
                somma += lancio;
                lstNomi.Items.Add(VetNomi[Pos]);
                lstMisure.Items.Add(VetMisure[Pos]);
                Pos++;
            }
            else
                MessageBox.Show("MASSIMO NUMERO DI ATLETI RAGGIUNTO");
            
   
        }

        private void lstNomi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMigliori.Items.Clear();

            int indice = lstNomi.SelectedIndex;
            int lancio = VetMisure[indice];

            for(int k = 0; k <= Pos-1; k++)
            {
                if(VetMisure[k] > lancio && k != indice)
                {
                    lstMigliori.Items.Add(VetNomi[k]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double media = Convert.ToDouble(somma / Pos + 1);
            lblMedia.Text = media.ToString();
        }
    }
}
