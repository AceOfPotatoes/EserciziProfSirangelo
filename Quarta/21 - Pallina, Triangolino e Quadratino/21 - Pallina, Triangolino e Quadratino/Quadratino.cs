using System.Drawing;
using System.Windows.Forms;

namespace _21___Pallina__Triangolino_e_Quadratino
{
    class Quadratino : FiguraGrafica
    {
        private int l;

        public Quadratino(int NuovaX, int NuovaY, int NuovaDir, int NuovoLato) : base(NuovaX, NuovaY, NuovaDir)
        {
            Lato = NuovoLato;
        }

        public int Lato
        {
            get { return l; }
            set { l = value; }
        }

        public override void Disegna(Panel Pannello, Pen Penna)
        {
            Graphics G = Pannello.CreateGraphics();
            G.DrawLine(Penna, X, Y, X + Lato, Y);
            G.DrawLine(Penna, X + Lato, Y, X + Lato, Y+Lato);
            G.DrawLine(Penna, X+Lato, Y+Lato, X, Y+Lato);
            G.DrawLine(Penna, X, Y + Lato, X, Y);
        }

        public override bool Fuori(Panel Pannello)
        {
            return (X < 0 || X > Pannello.Width-1 - Lato || Y < 0 || Y > Pannello.Height - 1 - Lato);
        }

        public override void InvertiDirezione(Panel Pannello)
        {
            if (X < 0)
                Direzione = 1;
            else if (X > Pannello.Width - 1 - Lato)
                Direzione = 3;
            else if (Y < 0)
                Direzione = 2;
            else
                Direzione = 0;
        }
    }
}
