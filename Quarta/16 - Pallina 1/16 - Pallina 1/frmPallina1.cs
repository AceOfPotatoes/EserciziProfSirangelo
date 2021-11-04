using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16___Pallina_1
{
    public partial class frmPallina1 : Form
    {
        public frmPallina1()
        {
            InitializeComponent();
        }

        Pallina MiaPallina;

        private void frmPallina1_Load(object sender, EventArgs e)
        {
            MiaPallina = new Pallina(149, 149, 50);
            Tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            MiaPallina.Muovi(Pannello);

            if (MiaPallina.Fuori(Pannello))
            {
                MiaPallina.RiposizionaNelPannello(Pannello);
            }
        }

        private void plsSu_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 0;
        }

        private void plsGiu_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 2;
        }

        private void plsSinistra_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 1;
        }

        private void plsDestra_Click(object sender, EventArgs e)
        {
            MiaPallina.Direzione = 3;
        }

    }
}
