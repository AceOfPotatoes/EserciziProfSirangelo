using System;

namespace _14___Punti_piano_cartesiano
{
    class Punto
    {
        private int _x;
        private int _y;

        public Punto() { _x = 0; _y = 0; }

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

        public double Distanza(Punto P2)
        {
            int AsseX = Convert.ToInt16(Quadrato(_x - P2.X));
            int AsseY = Convert.ToInt16(Quadrato(_y - P2.Y));
            return Math.Sqrt(AsseX + AsseY);
        }

        public bool StessoQuadrante(Punto P2)
        {
            if(_x > 0)
            {
                if (P2.X < 0)
                    return false;
                else if (_y > 0 && P2.Y > 0 || _y < 0 && P2.Y < 0)
                    return true;
                else
                    return false;
            }
            else
            {
                if (P2.X > 0)
                    return false;
                else if (_y > 0 && P2.Y > 0 || _y < 0 && P2.Y < 0)
                    return true;
                else
                    return false;
            }
        }

        public double PerimetroConOrigineE(Punto P1)
        {
            Punto O;
            O = new Punto();
            return (O.Distanza(P1) + Distanza(P1) + Distanza(O));
        }

        public bool DentroCerchio(int Raggio, Punto P)
        {
            Punto O;
            O = new Punto();
            return (Distanza(O) <= Raggio && P.Distanza(O) <= Raggio);
        }

        private int Quadrato(int Num)
        {
            return Convert.ToInt16(Math.Pow(Num, 2));
        }
    }
}
