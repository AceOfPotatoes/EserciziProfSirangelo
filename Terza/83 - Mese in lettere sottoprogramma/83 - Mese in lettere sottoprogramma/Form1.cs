using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _83___Mese_in_lettere_sottoprogramma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVai_Click(object sender, EventArgs e)
        {
            int G = Convert.ToByte(txtG.Text);
            int M = Convert.ToByte(txtM.Text);
            string Mese = MeseInLettere(M);
            if(Mese != "ERRORE")
            {
                MessageBox.Show(G.ToString() + " " + Mese);
            }          
        }

        private string MeseInLettere(int M)
        {
            switch (M)
            {
                case 1:
                    return "Gennaio";
                    
                case 2:
                    return "Febbraio";

                case 3:
                    return "Marzo";

                case 4:
                    return "Aprile";

                case 5:
                    return "Maggio";

                case 6:
                    return "Giugno";

                case 7:
                    return "Luglio";

                case 8:
                    return "Agosto";

                case 9:
                    return "Settembre";

                case 10:
                    return "Ottobre";

                case 11:
                    return "Novembre";

                case 12:
                    return "Dicembre";

                default:
                    MessageBox.Show("Mese maggiore di 12", "Errore");
                    return "ERRORE";                    
            }
        }
    }
}
