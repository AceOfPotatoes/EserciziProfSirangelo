using System;
using System.Drawing;
using System.Windows.Forms;

namespace _17___Pallina_2
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

        public bool Fuori(Panel Pannello)
        {
            return (X > Pannello.Width - 1 - Diametro || X < 0 || Y > Pannello.Height - 1 - Diametro || Y < 0);
        }

        public int Direzione
        {
            get { return _dir; }
            set
            {
                if (value >= 0 && value < 5)
                    _dir = value;
                else
                    MessageBox.Show("La direzione non è valida.", "ATTENZIONE");
            }
        }

        public void Muovi(Panel Pannello)
        {
            Disegna(Pannello, Pens.SeaGreen);

            switch (Direzione)
            {
                case 0: Y -= 2; break;      //Sopra
                case 1: X -= 2; break;      //Sinistra
                case 2: Y += 2; break;      //Sotto
                case 3: X += 2; break;      //Destra
                case 4:
                    Random R = new Random();
                    if (R.Next(2) == 0)        //Quindi modifica X        
                    {
                        if (R.Next(2) == 0)  //Quindi diminuisci X
                        {
                            X -= 2;
                            Direzione = 1;
                        }
                        else                    //Quindi aumenta X
                        {
                            X += 2;
                            Direzione = 3;
                        }
                        
                    }
                    else                        //Quindi modifica Y
                    {
                        if (R.Next(2) == 0)  //Quindi diminuisci Y
                        {
                            Y -= 2;
                            Direzione = 2;
                        }
                        else                    //Quindi aumenta Y
                        {
                            Y += 2;
                            Direzione = 0;
                        }    
                    }
                    break;
            }

            Disegna(Pannello, Pens.White);
        }

        public void Disegna(Panel Pannello, Pen Penna)
        {
            Graphics G = Pannello.CreateGraphics();
            G.DrawArc(Penna, X, Y, Diametro, Diametro, 0, 360);
        }

        public void RiposizionaNelPannello(Panel Pannello)
        {
            Disegna(Pannello, Pens.SeaGreen);

            if (X < 0)
                X = 0;
            else
                if (X > Pannello.Width - 1 - Diametro)
                X = Pannello.Width - 1 - Diametro;

            if (Y < 0)
                Y = 0;
            else
                if (Y > Pannello.Height - 1 - Diametro)
                Y = Pannello.Height - 1 - Diametro;

            Disegna(Pannello, Pens.White);
        }
    }
}
