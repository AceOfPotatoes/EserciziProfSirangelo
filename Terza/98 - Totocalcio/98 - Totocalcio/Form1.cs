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

namespace _98___Totocalcio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Squadra = Interaction.InputBox("Dammi il nome della squadra che vuoi aggiungere");
            lstElenco.Items.Add(Squadra);
            cmbSq1.Items.Add(Squadra);
            cmbSq2.Items.Add(Squadra);
        }


        private void plsTotocalcio_Click(object sender, EventArgs e)
        {
            if (numSq1.Value > numSq2.Value)
                lblRisultato.Text = "1";
            else
                if (numSq1.Value == numSq2.Value)
                lblRisultato.Text = "X";
                else
                    lblRisultato.Text = "2";
        }

        private void cmbSq2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSq2.SelectedIndex == cmbSq1.SelectedIndex)
            {
                MessageBox.Show("Abbinamento squadre impossibile");
                cmbSq2.SelectedIndex = -1;
            }
                
        }
    }
}
