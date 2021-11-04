using System.Drawing;
using System.Windows.Forms;

namespace _22___Ciambellina_e_Triangolino_Personalizzazioni
{
    class Triangolino : FiguraGrafica
    {
        private int b;
        private int h;
        
        public Triangolino(int NuovaX, int NuovaY, int NuovaDir, int NuovaBase, int NuovaAltezza) : base(NuovaX, NuovaY, NuovaDir)
        {
            Base = NuovaBase;
            Altezza = NuovaAltezza;
        }

        public int Base
        {
            get { return b; }
            set { b = value; }
        }

        public int Altezza
        {
            get { return h; }
            set { h = value; }
        }

        public override void Disegna(Panel Pannello, Pen Penna)
        {
            Graphics G = Pannello.CreateGraphics();
            G.DrawLine(Penna, X, Y, X + Base, Y);
            G.DrawLine(Penna, X + Base, Y, X + (Base / 2), Y + Altezza);
            G.DrawLine(Penna, X, Y, X + (Base / 2), Y + Altezza);
        }

        public override bool Fuori(Panel Pannello)
        {
            return (X < 0 || X > Pannello.Width - 1 - Base || Y < 0 || Y > Pannello.Height - 1 - Altezza);
        }

        public override void InvertiDirezione(Panel Pannello)
        {
            if (X < 0)
                Direzione = 1;
            else if (X > Pannello.Width - 1 - Base)
                Direzione = 3;
            else if (Y < 0)
                Direzione = 2;
            else
                Direzione = 0;
        }
    }
}
