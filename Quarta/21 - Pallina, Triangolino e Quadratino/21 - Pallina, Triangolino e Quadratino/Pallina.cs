using System.Drawing;
using System.Windows.Forms;

namespace _21___Pallina__Triangolino_e_Quadratino
{
    class Pallina : FiguraGrafica
    {
        private int diam;

        public Pallina(int NuovaX, int NuovaY, int NuovaDir, int NuovoDiametro) : base(NuovaX, NuovaY, NuovaDir)
        {
            Diametro = NuovoDiametro;
        }

        public int Diametro
        {
            get { return diam; }
            set { diam = value; }
        }

        public override void Disegna(Panel Pannello, Pen Penna)
        {
            Graphics G = Pannello.CreateGraphics();
            G.DrawArc(Penna, X, Y, Diametro, Diametro, 0, 360);
        }

        public override bool Fuori(Panel Pannello)
        {
            return (X < 0 || X > Pannello.Width - 1 - Diametro || Y < 0 || Y > Pannello.Height - 1 - Diametro);
        }

        public override void InvertiDirezione(Panel Pannello)
        {
            if (X < 0)
                Direzione = 1;
            else if (X > Pannello.Width - 1 - Diametro)
                Direzione = 3;
            else if (Y < 0)
                Direzione = 2;
            else
                Direzione = 0;
        }
    }
}
