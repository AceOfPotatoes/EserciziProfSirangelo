using System.Drawing;
using System.Windows.Forms;

namespace _23___Forme_varie_con_azioni_casuali
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
            set
            {
                if (diam != 0)
                    diam = value;
                else
                    diam = 5;
            }
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

        public override void CambiaDimensione(Panel Pannello)
        {
            Disegna(Pannello, Pens.Black);

            if (Diametro > 20 && Diametro < 200)
                Diametro += R.Next(-10, 10);
            else if (Diametro < 20)
                Diametro += R.Next(1, 20);
            else
                Diametro += R.Next(-20,-1);

            Disegna(Pannello, Pens.White);
        }
    }
}
