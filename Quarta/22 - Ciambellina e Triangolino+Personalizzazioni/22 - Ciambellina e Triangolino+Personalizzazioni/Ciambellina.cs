using System.Drawing;
using System.Windows.Forms;

namespace _22___Ciambellina_e_Triangolino_Personalizzazioni
{
    class Ciambellina : FiguraGrafica
    {
        private int DiamInt;
        private int DiamEst;

        public Ciambellina(int NuovaX, int NuovaY, int NuovaDir, int NuovoDiametroInterno, int NuovoDiametroEsterno) : base(NuovaX, NuovaY, NuovaDir)
        {
            DiamEst = NuovoDiametroEsterno;
            DiamInt = NuovoDiametroInterno;            
        }

        public int DiametroInterno
        {
            get { return DiamInt; }
            set
            {
                if (DiametroInterno < DiametroEsterno)
                    DiamInt = value;
                else
                    MessageBox.Show("Diametro interno > Diametro esterno", "ATTENZIONE");
            }
        }

        public int DiametroEsterno
        {
            get { return DiamEst; }
            set
            {
                if (DiametroEsterno > DiametroInterno)
                    DiamInt = value;
                else
                    MessageBox.Show("Diametro esterno < Diametro interno", "ATTENZIONE");
            }
        }

        public override void Disegna(Panel Pannello, Pen Penna)
        {
            Graphics G = Pannello.CreateGraphics();
            G.DrawArc(Penna, X, Y, DiametroEsterno, DiametroEsterno, 0, 360);
            G.DrawArc(Penna, X+DiametroEsterno / ((DiametroEsterno / DiametroInterno) * 2), Y+DiametroEsterno/ ((DiametroEsterno / DiametroInterno) * 2), DiametroInterno, DiametroInterno, 0, 360);
        }

        public override bool Fuori(Panel Pannello)
        {
            return (X < 0 || X > Pannello.Width - 1 - DiametroEsterno || Y < 0 || Y > Pannello.Height - 1 - DiametroEsterno);
        }

        public override void InvertiDirezione(Panel Pannello)
        {
            if (X < 0)
                Direzione = 1;
            else if (X > Pannello.Width - 1 - DiametroEsterno)
                Direzione = 3;
            else if (Y < 0)
                Direzione = 2;
            else
                Direzione = 0;
        }
    }
}

