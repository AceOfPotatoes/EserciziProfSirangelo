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

namespace _104___Lista_importi
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        int[] Vet;
        int Max = 0;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            Max = NumImporti();
            Vet = new int[Max];
        }

        private void plsInizia_Click(object sender, EventArgs e)
        {
            int k = 0;
            while (k < Max)
            {
                int imp = Input();
                Vet[k] += imp;
                ListaBox.Items.Add(imp);
                k++;
            }
        }

        private void plsSomma_Click(object sender, EventArgs e)
        {
            int somma = 0;
            for (int k = 0; k <= ListaBox.Items.Count - 1; k++)
                somma += Vet[k];

            MessageBox.Show("La somma degli importi inseriti è uguale a " + somma.ToString() + "€");
        }

        private void plsX_Click(object sender, EventArgs e)
        {
            int X = Input();
            int Pos = -1;
            Pos = ListaBox.Items.IndexOf(X);
            if(Pos != -1)
            {
                ListaBox.SelectedIndex = Pos;
                MessageBox.Show("La posizione dell'elemento nella lista è: " + Pos.ToString(), "ECCO LA POSIZIONE");
            }
            else
                MessageBox.Show("L'elemento non è presente nella lista", "ERRORE");




        }

        private void plsMax_Click(object sender, EventArgs e)
        {
            int Max = Int32.MinValue;

            for (int k = 0; k <= ListaBox.Items.Count-1; k++)
            {
                int N = Convert.ToInt32(ListaBox.Items[k]);
                if (N > Max)
                {
                    Max = N;
                }
            }
            ListaBox.SelectedIndex = ListaBox.Items.IndexOf(Max);
            MessageBox.Show("Il valore massimo è: " + Max.ToString(), "ECCO IL VALORE MASSIMO");
        }

        private int NumImporti()
        {
            int N;
            do
            {
                N = Convert.ToInt32(Interaction.InputBox("QUANTI IMPORTI HAI? (MAX 20)"));
                if (N > 20)
                    MessageBox.Show("MASSIMO 20 IMPORTI", "ERRORE");
            } while (N > 20);

            return N;
        }

        private int Input()
        {
            int N = int.Parse(Interaction.InputBox("DAMMI L'INPUT"));
            return N;
        }
    }
}
