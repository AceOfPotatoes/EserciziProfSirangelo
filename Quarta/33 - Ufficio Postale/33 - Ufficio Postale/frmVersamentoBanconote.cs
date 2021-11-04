using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33___Ufficio_Postale
{
    public partial class frmVersamentoBanconote : Form
    {
        public frmVersamentoBanconote()
        {
            InitializeComponent();
        }

        private List<double> ListaAccumuli;

        /* Basta non farci caso
        private double CinquecentoEuro = 0;
        private double DuecentoEuro = 0;
        private double CentoEuro = 0;
        private double CinquantaEuro = 0;
        private double VentiEuro = 0;
        private double DieciEuro = 0;
        private double CinqueEuro = 0;
        private double DueEuro = 0;
        private double UnEuro = 0;
        private double CinquantaCent = 0;
        private double VentiCent = 0;
        private double DieciCent = 0;
        private double CinqueCent = 0;
        private double UnCent = 0;
        */

        private void frmVersamentoBanconote_Load(object sender, EventArgs e)
        {
            ListaAccumuli = new List<double>();
        }

        public double TotaleVersato()
        {
            double TotaleAccumuli = 0;

            for (int k = 0; k < ListaAccumuli.Count; k++)
                TotaleAccumuli += ListaAccumuli[k];

            return TotaleAccumuli;
        }

        private void AggiornaLabelTotale(List<double> ListaAccumuli)
        {
            double TotaleAccumuli = 0;

            for (int k = 0; k < ListaAccumuli.Count; k++)
                TotaleAccumuli += ListaAccumuli[k];

            lblSoldiAccumulati.Text = TotaleAccumuli.ToString() + "€";  
        }

        private int QuanteBanconoteOMoneteVersateDi(double Valore, List<double> ListaAccumuli)
        {
            int DaRestituire = 0;
            for(int k = 0; k < ListaAccumuli.Count; k++)
            {
                if (ListaAccumuli[k] == Valore)
                    DaRestituire++;
                else if (ListaAccumuli[k] == -Valore)
                    DaRestituire--;
            }

            return DaRestituire;
        }

        private void AggiornaNumeroVersati(double Valore, Label lbl)
        {
            lbl.Text = Valore.ToString();
        }

        private void plsAggiungi500_Click(object sender, EventArgs e)
        {
            double Valore = 500;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl500);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai500_Click(object sender, EventArgs e)
        {
            double Valore = -500;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli)-1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl500);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre banconote da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi200_Click(object sender, EventArgs e)
        {
            double Valore = 200;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl200);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai200_Click(object sender, EventArgs e)
        {
            double Valore = -200;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl200);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre banconote da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi100_Click(object sender, EventArgs e)
        {
            double Valore = 100;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl100);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai100_Click(object sender, EventArgs e)
        {
            double Valore = -100;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl100);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre banconote da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi50_Click(object sender, EventArgs e)
        {
            double Valore = 50;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl50);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai50_Click(object sender, EventArgs e)
        {
            double Valore = -50;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl50);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre banconote da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi20_Click(object sender, EventArgs e)
        {
            double Valore = 20;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl20);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai20_Click(object sender, EventArgs e)
        {
            double Valore = -20;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl20);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre banconote da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi10_Click(object sender, EventArgs e)
        {
            double Valore = 10;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl10);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai10_Click(object sender, EventArgs e)
        {
            double Valore = -10;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl10);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre banconote da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi5_Click(object sender, EventArgs e)
        {
            double Valore = 5;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl5);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai5_Click(object sender, EventArgs e)
        {
            double Valore = -5;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl5);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre banconote da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi2_Click(object sender, EventArgs e)
        {
            double Valore = 2;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl2);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai2_Click(object sender, EventArgs e)
        {
            double Valore = -2;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl2);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre monete da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi1_Click(object sender, EventArgs e)
        {
            double Valore = 1;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl1);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai1_Click(object sender, EventArgs e)
        {
            double Valore = -1;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl1);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre monete da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi50cent_Click(object sender, EventArgs e)
        {
            double Valore = 0.50;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl50cent);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai50cent_Click(object sender, EventArgs e)
        {
            double Valore = -0.50;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl50cent);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre monete da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi20cent_Click(object sender, EventArgs e)
        {
            double Valore = 0.20;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl20cent);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai20cent_Click(object sender, EventArgs e)
        {
            double Valore = -0.20;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl20cent);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre monete da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi10cent_Click(object sender, EventArgs e)
        {
            double Valore = 0.10;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl10cent);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai10cent_Click(object sender, EventArgs e)
        {
            double Valore = -0.10;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl10cent);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre monete da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi5cent_Click(object sender, EventArgs e)
        {
            double Valore = 0.05;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl5cent);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai5cent_Click(object sender, EventArgs e)
        {
            double Valore = -0.05;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl5cent);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre monete da rimuovere", "ATTENZIONE");
        }

        private void plsAggiungi1cent_Click(object sender, EventArgs e)
        {
            double Valore = 0.01;
            ListaAccumuli.Add(Valore);
            AggiornaNumeroVersati(QuanteBanconoteOMoneteVersateDi(Valore, ListaAccumuli), lbl1cent);
            AggiornaLabelTotale(ListaAccumuli);
        }

        private void plsSottrai1cent_Click(object sender, EventArgs e)
        {
            double Valore = -0.01;
            int GiàVersate = QuanteBanconoteOMoneteVersateDi(-Valore, ListaAccumuli) - 1;
            if (GiàVersate >= 0)
            {
                ListaAccumuli.Add(Valore);
                AggiornaNumeroVersati(GiàVersate, lbl1cent);
                AggiornaLabelTotale(ListaAccumuli);
            }
            else
                MessageBox.Show("Non ci sono altre monete da rimuovere", "ATTENZIONE");
        }

        private void plsVersaSoldi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
