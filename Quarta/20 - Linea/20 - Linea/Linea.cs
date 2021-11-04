using System.Windows.Forms;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Linea
{
    class Linea
    {
        private int x;
        private int y;
        private int l;
        private int dir;
        private int p;

        public Linea(int x, int y, int l, int p)
        {
            this.x = x;
            this.y = y;
            this.l = l;
            this.p = p;
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

        public int Lunghezza
        {
            get { return l; }
            set { l = value; }
        }

        public int Direzione
        {
            get { return dir; }
            set { dir = value; }
        }

        public int Passo
        {
            get { return p; }
            set { p = value; }
        }

        public void AumentaLunghezza(Panel pnl)
        {
            DisegnaX(pnl, Pens.Salmon);
            DisegnaY(pnl, Pens.Salmon);
            if (Lunghezza < 294)
                Lunghezza += 5;
            else
                MessageBox.Show("Lunghezza massima raggiunta!!!", "Attenzione");
        }

        public void DiminuisciLunghezza(Panel pnl)
        {
            DisegnaX(pnl, Pens.Salmon);
            DisegnaY(pnl, Pens.Salmon);
            if (Lunghezza > 2)
                Lunghezza -= 2;
            else
                MessageBox.Show("Lunghezza minima raggiunta!!!", "Attenzione");
        }

        public void AumentaVelocità(Panel pnl)
        {
            DisegnaX(pnl, Pens.Salmon);
            DisegnaY(pnl, Pens.Salmon);
            if (Passo < 294)
                Passo += 5;
            else
                MessageBox.Show("Velocità massima raggiunta!!!", "Attenzione");
        }

        public void DiminuisciVelocità(Panel pnl)
        {
            DisegnaX(pnl, Pens.Salmon);
            DisegnaY(pnl, Pens.Salmon);
            if (Passo > 5)
                Passo -= 5;
            else
                MessageBox.Show("Velocità minima raggiunta!!!", "Attenzione");
        }

        public void Azzera(Panel pnl)
        {
            DisegnaX(pnl, Pens.Salmon);
            DisegnaY(pnl, Pens.Salmon);
            x = 0;
            y = 0;
            l = 10;
            Direzione = 1;
        }

        public void Muovi(Panel pnl)
        {
            DisegnaX(pnl, Pens.Salmon);
            DisegnaY(pnl, Pens.Salmon);

            switch (Direzione)
            {
                case 0:
                    DisegnaY(pnl, Pens.Salmon);
                    Y -= Passo;
                    DisegnaY(pnl, Pens.Black);
                    break;
                case 1:
                    DisegnaX(pnl, Pens.Salmon);
                    X += Passo;
                    DisegnaX(pnl, Pens.Black);
                    break;
                case 2:
                    DisegnaY(pnl, Pens.Salmon);
                    Y += Passo;
                    DisegnaY(pnl, Pens.Black);
                    break;
                case 3:
                    DisegnaX(pnl, Pens.Salmon);
                    X -= Passo;
                    DisegnaX(pnl, Pens.Black);
                    break;
            }
        }

        public void DisegnaX(Panel pnl, Pen Penna)
        {
            Graphics G = pnl.CreateGraphics();
            G.DrawLine(Penna, x, y+Lunghezza, x+Lunghezza, y+Lunghezza);

        }

        public void DisegnaY(Panel pnl, Pen Penna)
        {
            Graphics G = pnl.CreateGraphics();
            G.DrawLine(Penna, x + Lunghezza, y, x+Lunghezza, y + Lunghezza);
        }

        public void GiraASinistra()
        {
            switch (Direzione)
            {
                case 0: Direzione = 3; break;
                default: Direzione--; break;
            }
        }

        public void GiraADestra()
        {
            switch (Direzione)
            {
                case 3: Direzione = 0; break;
                default: Direzione++; break;
            }
        }

        public bool Fuori(Panel pnl)
        {
            switch (Direzione)
            {
                case 0:
                    return (Y - Lunghezza < 0);
                case 1:
                    return (X > pnl.Width-Lunghezza);
                case 2:
                    return (Y  > pnl.Height-Lunghezza);
                case 3:
                    return (X - Lunghezza < 0);
            }

            return false;
        }
    }
}
