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

namespace Modello_Matrici2
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        const int Max = 10;
        string[,] Mat;
        string[] VetRighe;
        string[] VetColonne;
        int NR = 0;
        int NC = 0;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            Mat = new string[Max, Max];
            VetRighe = new string[Max];
            VetColonne = new string[Max];
        }

        private void plsInput_Click(object sender, EventArgs e)
        {
            NR = Convert.ToInt16(numRighe.Value);
            NC = Convert.ToInt16(numColonne.Value);

            for (int R = 0; R <= NR - 1; R++)
            {
                for (int C = 0; C <= NC - 1; C++)
                {
                    string Elemento = "";
                    do
                    {
                        Elemento = Interaction.InputBox("Elemento (" + R + "," + C + ")" + ":").ToUpper();
                        if (Elemento.Length != 1)
                        {
                            MessageBox.Show("INSERIRE UN UNICO CARATTERE!!", "ATTENZIONE!!!");
                        }
                    } while (Elemento.Length != 1);
                     
                    Mat[R, C] = Elemento;
                }
            }
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            lstMat.Items.Clear();
            string Riga;
            for (int R = 0; R <= NR - 1; R++)
            {
                Riga = "";

                for (int C = 0; C <= NC - 1; C++)
                {
                    Riga += Mat[R, C].ToString().PadLeft(4);
                }
                lstMat.Items.Add(Riga);
            }
        }

        private void plsParola_Click(object sender, EventArgs e)
        {
            string Parola = Interaction.InputBox("Inserire qui la parola che si desidera ricercare", "ATTENZIONE").ToUpper();
            int Indice;
            bool Presente = false;
            for (int R = 0; R <= NR - 1; R++)
            {               
                for (int C = 0; C <= NC - 1; C++)
                {
                    VetRighe[R] += Mat[R, C]; 
                }
                Indice = VetRighe[R].IndexOf(Parola);

                if (Indice != -1)
                {
                    MessageBox.Show("La parola si trova nella riga " + R, "ATTENZIONE");
                    Presente = true;
                    break;
                }            
            }

            for (int C = 0; C <= NC - 1; C++)
            {
                for (int R = 0; R <= NR - 1; R++)
                {
                    VetColonne[C] += Mat[R, C];
                }
                Indice = VetColonne[C].IndexOf(Parola);

                if (Indice != -1)
                {
                    MessageBox.Show("La parola si trova nella colonna " +C, "ATTENZIONE");
                    Presente = true;
                    break;
                }
            }

            if (!Presente)
            {
                MessageBox.Show("La parola ricercata non è presente nella matrice", "ATTENZIONE");
            }
        }
    }
}
