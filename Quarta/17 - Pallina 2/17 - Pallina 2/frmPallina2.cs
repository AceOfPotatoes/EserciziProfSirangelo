using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17___Pallina_2
{
    public partial class frmPallina2 : Form
    {
        public frmPallina2()
        {
            InitializeComponent();
        }

        Pallina MiaPallina1;
        Pallina MiaPallina2;

        private void frmPallina2_Load(object sender, EventArgs e)
        {
            MiaPallina1 = new Pallina(49, 49, 30);
            MiaPallina2 = new Pallina(250, 250, 30);
            Tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            MiaPallina1.Muovi(Pannello);
            MiaPallina2.Muovi(Pannello);

            if (MiaPallina1.Fuori(Pannello))
                MiaPallina1.RiposizionaNelPannello(Pannello);

            if (MiaPallina2.Fuori(Pannello))
                MiaPallina2.RiposizionaNelPannello(Pannello);

        }

        private void plsSu1_Click(object sender, EventArgs e)
        {
            MiaPallina1.Direzione = 0;
        }

        private void plsSinistra1_Click(object sender, EventArgs e)
        {
            MiaPallina1.Direzione = 1;
        }

        private void plsGiu1_Click(object sender, EventArgs e)
        {
            MiaPallina1.Direzione = 2;
        }

        private void plsDestra1_Click(object sender, EventArgs e)
        {
            MiaPallina1.Direzione = 3;
        }

        private void plsCasuale1_Click(object sender, EventArgs e)
        {
            MiaPallina1.Direzione = 4;
        }

        private void plsSu2_Click(object sender, EventArgs e)
        {
            MiaPallina2.Direzione = 0;
        }

        private void plsSinistra2_Click(object sender, EventArgs e)
        {
            MiaPallina2.Direzione = 1;
        }

        private void plsGiu2_Click(object sender, EventArgs e)
        {
            MiaPallina2.Direzione = 2;
        }

        private void plsDestra2_Click(object sender, EventArgs e)
        {
            MiaPallina2.Direzione = 3;
        }

        private void plsCasuale2_Click(object sender, EventArgs e)
        {
            MiaPallina2.Direzione = 4;
        }
    }
}
