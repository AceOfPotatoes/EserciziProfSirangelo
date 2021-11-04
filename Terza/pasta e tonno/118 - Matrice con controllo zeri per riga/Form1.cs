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

namespace _118___Matrice_con_controllo_zeri_per_riga
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        const int Max = 10;
        int[,] Mat;
        int NR = 0;
        int NC = 0;
        int[] VetZeri;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            Mat = new int[Max, Max];
            VetZeri = new int[Max];
        }

        private void plsInput_Click(object sender, EventArgs e)
        {
            NR = Convert.ToInt16(numRighe.Value);
            NC = Convert.ToInt16(numColonne.Value);

            for (int R = 0; R <= NR - 1; R++)
            {
                VetZeri[R] = 0;
                for (int C = 0; C <= NC - 1; C++)
                {
                    int Elemento = Convert.ToInt16(Interaction.InputBox("Elemento (" + R + "," + C + ")" + ":"));
                    Mat[R, C] = Elemento;
                    if (Elemento == 0)
                        VetZeri[R]++;
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
                lstZeri.Items.Add(VetZeri[R]);
            }
        }
    }
}
