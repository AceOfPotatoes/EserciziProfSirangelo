using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21___Pallina__Triangolino_e_Quadratino
{
    public partial class frmPallinaTriangolinoQuadratino : Form
    {
        public frmPallinaTriangolinoQuadratino()
        {
            InitializeComponent();
        }

        Pallina miaPallina;
        Quadratino mioQuadratino;
        Triangolino mioTriangolino;

        private void mioTimer_Tick(object sender, EventArgs e)
        {
            miaPallina.Muovi(Pannello);
            mioQuadratino.Muovi(Pannello);
            mioTriangolino.Muovi(Pannello);

            if (miaPallina.Fuori(Pannello))
                miaPallina.InvertiDirezione(Pannello);

            if (mioQuadratino.Fuori(Pannello))
                mioQuadratino.InvertiDirezione(Pannello);

            if (mioTriangolino.Fuori(Pannello))
                mioTriangolino.InvertiDirezione(Pannello);

        }

        private void frmPallinaTriangolinoQuadratino_Load(object sender, EventArgs e)
        {
            miaPallina = new Pallina(100, 100, 2, 30);
            mioTriangolino = new Triangolino(200, 200, 0, 20, 20);
            mioQuadratino = new Quadratino(150, 150, 3, 40);
            mioTimer.Start();
        }

        private void frmPallinaTriangolinoQuadratino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                mioTriangolino.Direzione = 0;
            else if (e.KeyCode == Keys.Right)
                mioTriangolino.Direzione = 1;
            else if (e.KeyCode == Keys.Down)
                mioTriangolino.Direzione = 2;
            else if (e.KeyCode == Keys.Left)
                mioTriangolino.Direzione = 3;
            else if (e.KeyCode == Keys.W)
                miaPallina.Direzione = 0;
            else if (e.KeyCode == Keys.D)
                miaPallina.Direzione = 1;
            else if (e.KeyCode == Keys.S)
                miaPallina.Direzione = 2;
            else if (e.KeyCode == Keys.A)
                miaPallina.Direzione = 3;
            else if (e.KeyCode == Keys.I)
                mioQuadratino.Direzione = 0;
            else if (e.KeyCode == Keys.L)
                mioQuadratino.Direzione = 1;
            else if (e.KeyCode == Keys.K)
                mioQuadratino.Direzione = 2;
            else if (e.KeyCode == Keys.J)
                mioQuadratino.Direzione = 3;
        }
    }
}
