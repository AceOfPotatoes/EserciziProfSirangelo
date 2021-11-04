using System.Drawing;
using System.Windows.Forms;

namespace _22___Ciambellina_e_Triangolino_Personalizzazioni
{
    abstract class FiguraGrafica
    {
        private int x;
        private int y;
        private int dir;
        private int passo = 2;
        private int colore = 0;
        Pen _miaPennaFigura = new Pen(Color.Red);
        Pen _miaPennaSfondo = new Pen(Color.SlateBlue);
        
        public FiguraGrafica(int NuovaX, int NuovaY, int NuovaDir)
        {
            x = NuovaX;
            y = NuovaY;
            dir = NuovaDir;
        }
        
        public Pen miaPennaFigura
        {
            get { return _miaPennaFigura; }
            set { _miaPennaFigura = value; }
        }

        public Pen miaPennaSfondo
        {
            get { return _miaPennaSfondo; }
            set { _miaPennaSfondo = value; }
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

        public void CambiaColore()
        {
            switch (colore)
            {
                case 0: miaPennaFigura = new Pen(Color.Red); colore++; break;
                case 1: miaPennaFigura = new Pen(Color.White); colore++; break;
                case 2: miaPennaFigura = new Pen(Color.Blue); colore++; break;
                case 3: miaPennaFigura = new Pen(Color.LightGreen); colore++; break;
                case 4: miaPennaFigura = new Pen(Color.Black); colore++; break;
                case 5: miaPennaFigura = new Pen(Color.Orange); colore++; break;
                case 6: miaPennaFigura = new Pen(Color.Yellow); colore++; break;
                case 7: miaPennaFigura = new Pen(Color.Aquamarine); colore = 0; break;
            }            
        }
    
        public void AumentaVelocità()
        {
            if (Passo < 100)
                Passo += 2;
            else
                MessageBox.Show("Velocità massima raggiunta", "ATTENZIONE");
        }

        public void DiminuisciVelocità()
        {
            if (Passo > 3)
                Passo -= 2;
            else
                MessageBox.Show("Velocità minima raggiunta", "ATTENZIONE");
        }

        public void Muovi(Panel Pannello, Pen PennaFigura, Pen PennaSfondo)
        {
            Disegna(Pannello, PennaSfondo);
            switch (Direzione)
            {
                case 0: Y -= Passo; break;
                case 1: X += Passo; break;
                case 2: Y += Passo; break;
                case 3: X -= Passo; break;
            }
            Disegna(Pannello, PennaFigura);
        }

        public abstract void Disegna(Panel Pannello, Pen Penna);
        public abstract bool Fuori(Panel Pannello);
        public abstract void InvertiDirezione(Panel Pannello);
    }
}
