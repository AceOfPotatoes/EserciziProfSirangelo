using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _23___Forme_varie_con_azioni_casuali
{
    class FiguraGrafica
    {
        private int x;
        private int y;
        private int dir;
        private int passo = 2;
        List<FiguraGrafica> _ListaFigure = new List<FiguraGrafica>();
        public Random R = new Random();

        public FiguraGrafica() { }

        public FiguraGrafica(int NuovaX, int NuovaY, int NuovaDir)
        {
            x = NuovaX;
            y = NuovaY;
            dir = NuovaDir;
        }

        public List<FiguraGrafica> ListaFigure
        {
            get { return _ListaFigure; }
            set { }
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

        public int Passo
        {
            get { return passo; }
            set { passo = value; }
        }

        public void CambiaVelocità()
        {
            if (Passo > 10 && Passo < 150)
                Passo += R.Next(-3, +2);
            else if (Passo > 150)
                Passo += R.Next(-3, 0);
            else
                Passo += R.Next(1, 5);
        }


        public void Muovi(Panel Pannello)
        {
            Disegna(Pannello, Pens.Black);
            switch (Direzione)
            {
                case 0: Y -= Passo; break;
                case 1: X += Passo; break;
                case 2: Y += Passo; break;
                case 3: X -= Passo; break;
            }
            Disegna(Pannello, Pens.White);
        }

        public void CreaFigura()
        {
            switch (Convert.ToInt32(R.Next(0, 4)))
            {
                case 0: ListaFigure.Add(new Pallina(149, 149, 0, 30)); break;
                case 1: ListaFigure.Add(new Quadratino(149, 149, 1, 30)); break;
                case 2: ListaFigure.Add(new Triangolino(149, 149, 2, 30, 30)); break;
                case 3: ListaFigure.Add(new Stellina(149, 149, 3, 30)); break;
            }
        }

        public void CambiaDirezione()
        {
            int Casuale = Convert.ToInt32(R.Next(4));
            if(Casuale == Direzione)
                Casuale = Convert.ToInt32(R.Next(4));
            switch (Casuale)
            {
                case 0: Direzione = 0; break;
                case 1: Direzione = 1; break;
                case 2: Direzione = 2; break;
                case 3: Direzione = 3; break;
            }
        }

        public virtual void CambiaDimensione(Panel Pannello) { }
        public virtual void Disegna(Panel Pannello, Pen Penna) { }
        public virtual bool Fuori(Panel Pannello) { return false; }
        public virtual void InvertiDirezione(Panel Pannello) { }
    }
}
