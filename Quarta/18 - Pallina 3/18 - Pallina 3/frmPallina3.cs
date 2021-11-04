using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18___Pallina_3
{
    public partial class frmPallina3 : Form
    {
        public frmPallina3()
        {
            InitializeComponent();
        }

        Pallina MiaPallina;

        private void frmPallina3_Load(object sender, EventArgs e)
        {
            MiaPallina = new Pallina(134, 0, 30);
            Tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            MiaPallina.Muovi(Pannello);

            if (MiaPallina.Fuori(Pannello))
                MiaPallina.Rimbalza(Pannello);
        }

        private void plsPiuVeloce_Click(object sender, EventArgs e)
        {
            MiaPallina.AumentaVelocità(Pannello, Tmr);
        }

        private void plsMenoVeloce_Click(object sender, EventArgs e)
        {
            MiaPallina.DiminuisciVelocità(Pannello, Tmr);
        }

        private void plsPiuGrande_Click(object sender, EventArgs e)
        {
            MiaPallina.AumentaDimensione(Pannello);
        }

        private void plsMenoGrande_Click(object sender, EventArgs e)
        {
            MiaPallina.DiminuisciDimensione(Pannello);            
        }

        private void plsN_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 0;
        }

        private void plsNO_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 1;
        }

        private void plsO_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 2;
        }

        private void plsSO_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 3;
        }

        private void plsS_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 4;
        }

        private void plsSE_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 5;
        }

        private void plsE_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 6;
        }

        private void plsNE_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 7;
        }

    }
}
