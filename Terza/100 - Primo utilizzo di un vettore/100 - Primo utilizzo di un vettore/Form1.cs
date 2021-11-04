using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _100___Primo_utilizzo_di_un_vettore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Vet;
        int Num = 0;
        const int Max = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            Vet = new int[Max];
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            if(Num < Max)
            {
                Vet[Num] = Convert.ToInt32(Interaction.InputBox("Dammi il numero che vuoi aggiungere al vettore"));
                Num++;
            }
            else
            {
                MessageBox.Show("Raggiunto limite elementi massimo", "ERRORE");
            }

            lblNum.Text = Num.ToString() + "/" + Max.ToString();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            for(int k = 0; k <= Num-1; k++)
            {
                lstVet.Items.Add(Vet[k]);
            }
        }

        private void plsSomma_Click(object sender, EventArgs e)
        {
            int Somma = 0;

            for (int k = 0; k <= Num - 1; k++)
            {
                Somma += Vet[k];
            }

            MessageBox.Show("La somma degli elementi del vettore è " + Somma.ToString(), "SOMMA");
        }

        private void plsRimuovi_Click(object sender, EventArgs e)
        {
            lstVet.Items.Clear();
        
            for (int k = 0; k <= Num - 1; k++)
            {
                Vet[k] = 0;
            }

            Num = 0;

            lblNum.Text = Num.ToString() + "/" + Max.ToString();
        }
    }
}
