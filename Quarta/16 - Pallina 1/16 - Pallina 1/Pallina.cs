using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _16___Pallina_1
{
    class Pallina
    {
        private int _x;
        private int _y;
        private int _diam;
        private int _dir;

        public Pallina(int NuovaX, int NuovaY, int NuovoDiametro)
        {
            X = NuovaX;
            Y = NuovaY;
            Diametro = NuovoDiametro;
            //Direzione -> in basso;
            Direzione = 2; 
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Diametro
        {
            get { return _diam; }
            set { _diam = value; }
        }

        public int Direzione
        {
            get { return _dir; }
            set
            {
                if (value >= 0 && value < 4)
                    _dir = value;
                else
                    MessageBox.Show("La direzione non è valida.", "ATTENZIONE");                   
            }
        }

        public void Disegna(Panel Pannello, Pen Penna)
        {
            Graphics G = Pannello.CreateGraphics();
            G.DrawArc(Penna, X, Y, Diametro, Diametro, 0, 360);
        }

        public void Muovi(Panel Pannello)
        {
            Disegna(Pannello, Pens.Black);

            switch (Direzione)
            {
                case 0: Y -= 2; break;      //Sopra
                case 1: X -= 2; break;      //Sinistra
                case 2: Y += 2; break;      //Sotto
                case 3: X += 2; break;      //Destra
            }

            Disegna(Pannello, Pens.NavajoWhite);
        }

        public bool Fuori(Panel Pannello)
        {
            return (X > Pannello.Width-1-Diametro || X < 0 || Y > Pannello.Height-1-Diametro || Y < 0);
        }

        public void RiposizionaNelPannello(Panel Pannello)
        {
            Disegna(Pannello, Pens.Black);

            if (X < 0 - Diametro)
                X = Pannello.Width - 1;
            else
                if (X > Pannello.Width - 1)
                    X = 0;

            if (Y < 0)
                Y = Pannello.Height - 1;
            else
                if (Y > Pannello.Height - 1)
                    Y = 0; 
            
            Disegna(Pannello, Pens.NavajoWhite);
        }
    }
}
