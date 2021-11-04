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

namespace _101___Numero_maschi_e_femmine_vettori
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }


        int Max;
        string[] VetF;
        string[] VetM;
        int NumM = 0;
        int NumF = 0;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            int MaxDaControllare = Convert.ToInt16(Interaction.InputBox("Dammi il numero dei nominativi (MAX 20)", "QUANTI NOMINATIVI ABBIAMO (MAX 20)?"));
            if(MaxDaControllare <= 20)
            {
                Max = MaxDaControllare;
            }
            else
            {
                Environment.Exit(Convert.ToInt16(MessageBox.Show("INSERIRE NUMERO NOMINATIVI VALIDO (<= 20), il software verrà chiuso brutalmente!!!", "ERRORE CRITICO")));
            }

            VetF = new string[Max];
            VetM = new string[Max];
        }

        private void plsInizia_Click(object sender, EventArgs e)
        {                 
            string Genere;
            string Nome;
            for (int K = 0; K <= Max - 1; K++)
            {
                Genere = Interaction.InputBox("L'individuo è Maschio o Femmina? (INDICARE CON M/F)", "A QUALE GENERE APPARTIENE?");
                Nome = Interaction.InputBox("Dammi il nome dell'individuo", "ASPETTO IL NOME...");
                if (Genere == "M")
                {
                    VetM[NumM] = Nome;
                    NumM++;
                }
                else
                {
                    VetF[NumF] = Nome;
                    NumF++;
                }
            }               
        }

        private void plsVis_Click(object sender, EventArgs e)
        { 
            for(int K = 0; K <= NumF-1; K++)
            {
                lstF.Items.Add(VetF[K]);
            }

            for (int K = 0; K <= NumM - 1; K++)
            {
                lstM.Items.Add(VetM[K]);
            }

            lblFemmine.Text = NumF.ToString();
            lblMaschi.Text = NumM.ToString();
        }
    }
}
