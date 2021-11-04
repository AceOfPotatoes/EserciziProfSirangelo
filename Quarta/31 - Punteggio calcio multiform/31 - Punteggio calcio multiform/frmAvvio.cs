using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31___Punteggio_calcio_multiform
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        

        private void plsPrendiInputDati_Click(object sender, EventArgs e)
        {
            frmInputGolSegnati SecondaForm = new frmInputGolSegnati();

            SecondaForm.ShowDialog();

            lblDatiPartita.Text = SecondaForm.NomeSquadra1 + " " + SecondaForm.GolSquadra1 + " - " + SecondaForm.GolSquadra2 + " " + SecondaForm.NomeSquadra2;
            if (SecondaForm.GolSquadra1 > SecondaForm.GolSquadra2)
            {
                lblNomeSquadra1.Text = SecondaForm.NomeSquadra1;
                lblNomeSquadra2.Text += SecondaForm.NomeSquadra2;
                lblPunteggioSquadra1.Text = "3";
                lblPunteggioSquadra2.Text = "0";
            }
            else if(SecondaForm.GolSquadra1 < SecondaForm.GolSquadra2)
            {
                lblNomeSquadra1.Text = SecondaForm.NomeSquadra1;
                lblNomeSquadra2.Text += SecondaForm.NomeSquadra2;
                lblPunteggioSquadra1.Text = "0";
                lblPunteggioSquadra2.Text = "3";
            }
            else
            {
                lblNomeSquadra1.Text = SecondaForm.NomeSquadra1;
                lblNomeSquadra2.Text += SecondaForm.NomeSquadra2;
                lblPunteggioSquadra1.Text = "1";
                lblPunteggioSquadra2.Text = "1";
            }
                
        }
    }
}
