using System.Drawing;
using System.Windows.Forms;


namespace _21___Pallina__Triangolino_e_Quadratino
{
    abstract class FiguraGrafica
    {
        private int x;
        private int y;
        private int dir;

        public FiguraGrafica(int NuovaX, int NuovaY, int NuovaDir)
        {
            x = NuovaX;
            y = NuovaY;
            dir = NuovaDir;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Direzione
        {
            get { return dir; }
            set { dir = value; }
        }

        public void Muovi(Panel Pannello)
        {
            Disegna(Pannello, Pens.CornflowerBlue);
            switch (Direzione)
            {
                case 0: Y -= 2; break;
                case 1: X += 2; break;
                case 2: Y += 2; break;
                case 3: X -= 2; break;
            }
            Disegna(Pannello, Pens.Black);
        }

        public abstract void Disegna(Panel Pannello, Pen Penna);
        public abstract bool Fuori(Panel Pannello);
        public abstract void InvertiDirezione(Panel Pannello);
    }
}
