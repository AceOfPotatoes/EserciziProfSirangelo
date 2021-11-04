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

namespace _116___Matrice_con_vettore_somma_righe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int Max = 10;
        int NR = 0;
        int NC = 0;
        int[,] Mat;
        int[] VetSomme;

        private void Form1_Load(object sender, EventArgs e)
        {
            Mat = new int[Max, Max];
            VetSomme = new int[Max];
        }

        private void plsInput_Click(object sender, EventArgs e)
        {
            NR = Convert.ToInt16(numRighe.Value);
            NC = Convert.ToInt16(numColonne.Value);

            for (int R = 0; R <= NR - 1; R++)
            {
                VetSomme[R] = 0;
                for (int C = 0; C <= NC - 1; C++)
                {
                    int Elemento = Convert.ToInt16(Interaction.InputBox("Elemento" + "(" + R + "," + C + ")"));
                    Mat[R, C] = Elemento;
                    VetSomme[R] += Elemento;
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

            int Maggiore = RigaMaggiore(VetSomme, NR);

            MessageBox.Show("La riga con la somma più elevata è la n° " + Maggiore);
        }

        private int RigaMaggiore(int[] VetSomme, int NR)
        {
            int RigMag = 0;
            for (int k = 1; k<=NR-1; k++)
            {
                
                if (VetSomme[k] > VetSomme[RigMag])
                    RigMag = k;
            }

            return RigMag;            
        }        
    }
}
