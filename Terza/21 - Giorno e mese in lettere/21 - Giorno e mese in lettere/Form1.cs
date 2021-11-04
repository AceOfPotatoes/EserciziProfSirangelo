using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21___Giorno_e_mese_in_lettere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            byte G = Convert.ToByte(txtG.Text);
            byte M = Convert.ToByte(txtM.Text);


            lblG.Text = G.ToString();

            switch (M)
            {
                case 1:
                    lblM.Text = "Gennaio";
                    break;

                case 2:
                    lblM.Text = "Febbraio";
                    break;

                case 3:
                    lblM.Text = "Marzo";
                    break;

                case 4:
                    lblM.Text = "Aprile";
                    break;

                case 5:
                    lblM.Text = "Maggio";
                    break;

                case 6:
                    lblM.Text = "Giugno";
                    break;

                case 7:
                    lblM.Text = "Luglio";
                    break;

                case 8:
                    lblM.Text = "Agosto";
                    break;

                case 9:
                    lblM.Text = "Settembre";
                    break;

                case 10:
                    lblM.Text = "Ottobre";
                    break;

                case 11:
                    lblM.Text = "Novembre";
                    break;

                case 12:
                    lblM.Text = "Dicembre";
                    break;

                default:
                    lblM.Text = "ERRORE!!!";
                    break;
            }
        }
    }
}
