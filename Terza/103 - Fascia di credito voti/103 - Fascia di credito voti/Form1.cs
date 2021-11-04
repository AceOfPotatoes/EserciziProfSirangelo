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

namespace _103___Fascia_di_credito_voti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mi sono poi reso conto che non mi serviva, capita...
        }

        private void plsVettore_Click(object sender, EventArgs e)
        {
            int Max = numVoti();            //Stabilisco il numero dei voti...
            int[] Lista = new int[Max];       //Dichiaro e creo il vettore...
            double somma = 0;                  //Accumulatore...
            bool tre = false;               //Variabile controllo presenza "3"...
            int VotoMax = Int16.MaxValue;       //Metto in min il valore massimo di un Int16 (lo assegnerò per bene dopo)...
            
            for(int k = 0; k<=Max-1; k++)
            {
                Lista[k] = Input();

                if (k == 0)
                    VotoMax = Lista[k];

                somma += Lista[k];

                if (Lista[k] == 3)
                    tre = true;

                if (Lista[k] > VotoMax)
                    VotoMax = Lista[k];           
            }
            double media = Media(somma, Max);
            lblMedia.Text = media.ToString();
            lblMax.Text = VotoMax.ToString();
            lblTre.Text = BoolStringa(tre);
            lblFascia.Text = Fascia(media);
        }

        private void plsList_Click(object sender, EventArgs e)
        {
            List<int> Lista = new List<int>();
            int Max = numVoti();            //Stabilisco il numero dei voti...
            double somma = 0;                  //Accumulatore...
            bool tre = false;               //Variabile controllo presenza "3"...
            int VotoMax = Int16.MaxValue;       //Metto in min il valore massimo di un Int16 (lo assegnerò per bene dopo)...

            for (int k = 0; k <= Max - 1; k++)
            {
                Lista.Add(Input());
                
                if (k == 0)
                    VotoMax = Lista[k];

                somma += Lista[k];

                if (Lista[k] == 3)
                    tre = true;

                if (Lista[k] > VotoMax)
                    VotoMax = Lista[k];
            }

            double media = Media(somma, Max);
            lblMedia.Text = media.ToString();
            lblMax.Text = VotoMax.ToString();
            lblTre.Text = BoolStringa(tre);
            lblFascia.Text = Fascia(media);
        }


        private int numVoti()
        {
            int N;
            do
            {
                N = int.Parse(Interaction.InputBox("DAMMI IL NUMERO DI VOTI"));
                if (N > 10)
                    MessageBox.Show("MAX 10 MATERIE", "ERRORE");
            } while (N >= 10);    

                    return N;
        }

        private int Input()
        {
            int Voto;
            do
            {
                Voto = int.Parse(Interaction.InputBox("DAMMI IL VOTO DA INSERIRE"));
                if (Voto > 10)
                    MessageBox.Show("VOTO > 10", "ERRORE");
            } while (Voto > 10);

            return Voto;
        }

        private double Media(double somma, int max)
        {
            return somma / max;
        }

        private string BoolStringa(bool tre)
        {
            if(tre)
                return "SI";
            else
                return "NO";
        }

        private string Fascia(double media)
        {
            string Fascia = "";
            if (media < 6)
                Fascia = "FASCIA A";

            if (media >= 6 && media < 8)
                Fascia = "FASCIA B";

            if (media >= 8)
                Fascia = "FASCIA C";

            return Fascia;
        }
       
    }
}
