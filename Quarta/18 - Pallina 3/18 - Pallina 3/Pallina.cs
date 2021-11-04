using System;
using System.Drawing;
using System.Windows.Forms;

namespace _18___Pallina_3
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

        public int Direzione
        {
            get { return _dir; }
            set
            {
                if (value >= 0 && value < 8)
                    _dir = value;
                else
                    MessageBox.Show("La direzione non è valida.", "ATTENZIONE");
            }
        }

        public bool Fuori(Panel Pannello)
        {
            return (X > Pannello.Width - 1 - Diametro || X < 0 || Y > Pannello.Height - 1 - Diametro || Y < 0);
        }

        

        public void Muovi(Panel Pannello)
        {
            Disegna(Pannello, Pens.Maroon);

            switch (Direzione)
            {
                case 0: Y -= 2; break;      
                case 1: X -= 2; Y -= 2; break;      
                case 2: X -= 2; break;      
                case 3: X -= 2; Y += 2; break;      
                case 4: Y += 2; break;
                case 5: X += 2; Y += 2; break;
                case 6: X += 2; break;
                case 7: X += 2; Y -= 2; break;
            }

            Disegna(Pannello, Pens.White);
        }

        public void Disegna(Panel Pannello, Pen Penna)
        {
            Graphics G = Pannello.CreateGraphics();
            G.DrawArc(Penna, X, Y, Diametro, Diametro, 0, 360);
        }

        public void Rimbalza(Panel Pannello)
        {
            Disegna(Pannello, Pens.Maroon);

            switch (Direzione)
            {
                case 0:
                    Direzione = 4; break;

                case 1:
                    if (X < 0)
                        Direzione = 7;
                    else
                        Direzione = 3;
                    break;

                case 2:
                    Direzione = 6; break;

                case 3:
                    if (X < 0)
                        Direzione = 5;
                    else
                        Direzione = 1;
                    break;

                case 4:
                    Direzione = 0; break;

                case 5:
                    if (X > Pannello.Width - 1 - Diametro)
                        Direzione = 3;
                    else
                        Direzione = 7;
                    break;

                case 6:
                    Direzione = 2; break;

                case 7:
                    if (Y < 0)
                        Direzione = 5;
                    else
                        Direzione = 1;
                    break;
            }

            /*if (X < 0)
                X = 0;
            else
                if (X > Pannello.Width - 1 - Diametro)
                X = Pannello.Width - 1 - Diametro;

            if (Y < 0)
                Y = 0;
            else
                if (Y > Pannello.Height - 1 - Diametro)
                Y = Pannello.Height - 1 - Diametro;*/

            Disegna(Pannello, Pens.White);
        }

        public void DiminuisciDimensione(Panel Pannello)
        {
            Disegna(Pannello, Pens.Maroon);
            if (Diametro > 5)
                Diametro -= 5;
            else
                MessageBox.Show("Dimensione minima raggiunta!!!", "Attenzione");
            Disegna(Pannello, Pens.White);
        }

        public void AumentaDimensione(Panel Pannello)
        {
            Disegna(Pannello, Pens.Maroon);
            if (Diametro < 294)
                Diametro += 5;
            else
                MessageBox.Show("Dimensione massima raggiunta!!!", "Attenzione");
            Disegna(Pannello, Pens.White);
        }

        public void AumentaVelocità(Panel Pannello, Timer Tmr)
        {
            if (Tmr.Interval > 2)
                Tmr.Interval -= 2;
            else
                MessageBox.Show("Raggiunta velocità massima!!!", "Attenzione");
        }

        public void DiminuisciVelocità(Panel Pannello, Timer Tmr)
        {
            Tmr.Interval += 2;
        }
    }
}
