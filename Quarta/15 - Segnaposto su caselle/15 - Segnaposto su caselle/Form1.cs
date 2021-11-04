using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15___Segnaposto_su_caselle
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        Random R = new Random();
        Segnaposto G1 = new Segnaposto();
        Segnaposto G2 = new Segnaposto();
        Dado D = new Dado();
        Percorso P = new Percorso();

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            
            P.CreaPercorso(lstPercorso);
        }

        private void plsDadoG1_Click(object sender, EventArgs e)
        {
            EsciDaCasella(G1);
            G1.AvanzaDi(D.LanciaDado());
            if (G1.CasellaOccupata > 100)
                MessageBox.Show("GIOCATORE 1 HA VINTO!!!", "ATTENZIONE");
            else
            {
                ControllaTrappola(G1);

                if (G1.CasellaOccupata != G2.CasellaOccupata)
                {
                    lstPercorso.Items[G2.CasellaOccupata].BackColor = Color.Yellow;
                    lstPercorso.Items[G1.CasellaOccupata].BackColor = Color.Red;
                }
                else
                    lstPercorso.Items[G1.CasellaOccupata].BackColor = Color.Orange;
            }
            G1.AssegnaPosizione(G2);
            AggiornaLabelStatisticheG1();
            AggiornaLabelStatisticheG2();
            plsDadoG1.Visible = false;
            plsDadoG2.Visible = true;

        }

        private void plsDadoG2_Click(object sender, EventArgs e)
        {
            EsciDaCasella(G2);
            G2.AvanzaDi(D.LanciaDado());
            if (G2.CasellaOccupata > 100)
                MessageBox.Show("GIOCATORE 2 HA VINTO!!!", "ATTENZIONE");
            else
            {
                ControllaTrappola(G2);

                if (G1.CasellaOccupata != G2.CasellaOccupata)
                {
                    lstPercorso.Items[G2.CasellaOccupata].BackColor = Color.Yellow;
                    lstPercorso.Items[G1.CasellaOccupata].BackColor = Color.Red;
                }                    
                else
                    lstPercorso.Items[G2.CasellaOccupata].BackColor = Color.Orange;
            }
            G2.AssegnaPosizione(G1);
            AggiornaLabelStatisticheG1();
            AggiornaLabelStatisticheG2();
            plsDadoG2.Visible = false;
            plsDadoG1.Visible = true;            
        }

        private void ControllaTrappola(Segnaposto G)
        {
            int ContenutoCasella = P.VetPercorso[G.CasellaOccupata];
            if (ContenutoCasella != 0)
            {
                MessageBox.Show("Sei finito su una trappola che ti farà tornare indietro di " + ContenutoCasella + " caselle", "ATTENZIONE");
                G.Arretra(ContenutoCasella);
            }
        }

        private void EsciDaCasella(Segnaposto G)
        {
            lstPercorso.Items[G.CasellaOccupata].BackColor = Color.White;
        }

        private void AggiornaLabelStatisticheG1()
        {
            lblCasellaG1.Text = (G1.CasellaOccupata+1).ToString();
            lblPosG1.Text = G1.Posizione.ToString();
        }

        private void AggiornaLabelStatisticheG2()
        {
            lblCasellaG2.Text = (G2.CasellaOccupata+1).ToString();
            lblPosG2.Text = G2.Posizione.ToString();
        }
    }
}
