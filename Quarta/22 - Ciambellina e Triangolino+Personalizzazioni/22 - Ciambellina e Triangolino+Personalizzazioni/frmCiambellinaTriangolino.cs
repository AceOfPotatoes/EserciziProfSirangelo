using System;
using System.Drawing;
using System.Windows.Forms;

namespace _22___Ciambellina_e_Triangolino_Personalizzazioni
{
    public partial class frmCiambellinaTriangolino : Form
    {
        public frmCiambellinaTriangolino()
        {
            InitializeComponent();
        }

        Ciambellina miaCiambellina;
        Triangolino mioTriangolino;

        private void frmCiambellinaTriangolino_Load(object sender, EventArgs e)
        {
            miaCiambellina = new Ciambellina(100, 100, 2, 20, 40);
            mioTriangolino = new Triangolino(200, 200, 0, 40, 40);
            miaCiambellina.miaPennaFigura = Pens.Red;
            mioTriangolino.miaPennaSfondo = Pens.Black;
            mioTimer.Start();
        }

        private void mioTimer_Tick(object sender, EventArgs e)
        {
            miaCiambellina.Muovi(Pannello, miaCiambellina.miaPennaFigura, miaCiambellina.miaPennaSfondo);
            mioTriangolino.Muovi(Pannello, mioTriangolino.miaPennaFigura, miaCiambellina.miaPennaSfondo);

            if (miaCiambellina.Fuori(Pannello))
                miaCiambellina.InvertiDirezione(Pannello);

            if (mioTriangolino.Fuori(Pannello))
                mioTriangolino.InvertiDirezione(Pannello);
        }

        private void frmCiambellinaTriangolino_KeyDown(object sender, KeyEventArgs e)
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
                miaCiambellina.Direzione = 0;
            else if (e.KeyCode == Keys.D)
                miaCiambellina.Direzione = 1;
            else if (e.KeyCode == Keys.S)
                miaCiambellina.Direzione = 2;
            else if (e.KeyCode == Keys.A)
                miaCiambellina.Direzione = 3;
            else if (e.KeyCode == Keys.C)
                miaCiambellina.CambiaColore();
            else if (e.KeyCode == Keys.T)
                mioTriangolino.CambiaColore();
            else if (e.KeyCode == Keys.PageUp)
                miaCiambellina.AumentaVelocità();
            else if (e.KeyCode == Keys.PageDown)
                miaCiambellina.DiminuisciVelocità();
            else if (e.KeyCode == Keys.O)
                mioTriangolino.AumentaVelocità();
            else if (e.KeyCode == Keys.L)
                mioTriangolino.DiminuisciVelocità();
        }
    }
}
