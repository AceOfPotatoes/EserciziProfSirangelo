using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20___Linea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Linea miaLinea;

        private void Tmr_Tick(object sender, EventArgs e)
        {
            miaLinea.Muovi(pnl);

            if (miaLinea.Fuori(pnl))
            {
                switch (miaLinea.Direzione)
                {
                    case 1:
                        miaLinea.DisegnaX(pnl, Pens.Salmon);
                        miaLinea.X -= miaLinea.Lunghezza;
                        break;
                    case 2:
                        miaLinea.DisegnaY(pnl, Pens.Salmon);
                        miaLinea.Y -= miaLinea.Lunghezza;
                        break;
                    case 3:
                        miaLinea.DisegnaX(pnl, Pens.Salmon);
                        miaLinea.X += miaLinea.Lunghezza;
                        break;                    
                }
                miaLinea.GiraADestra();
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miaLinea = new Linea(100, 100, 10, 5);
            Tmr.Start();
        }

        private void plsSinistra_Click(object sender, EventArgs e)
        {
            miaLinea.GiraASinistra();
        }

        private void plsDestra_Click(object sender, EventArgs e)
        {
            miaLinea.GiraADestra();
        }

        private void plsAumentaVelocità_Click(object sender, EventArgs e)
        {
            miaLinea.AumentaVelocità(pnl);
        }

        private void plsDiminuisciVelocità_Click(object sender, EventArgs e)
        {
            miaLinea.DiminuisciVelocità(pnl);
        }

        private void plsAllunga_Click(object sender, EventArgs e)
        {
            miaLinea.AumentaLunghezza(pnl);
        }

        private void plsAccorcia_Click(object sender, EventArgs e)
        {
            miaLinea.DiminuisciLunghezza(pnl);
        }

        private void plsAzzera_Click(object sender, EventArgs e)
        {
            miaLinea.Azzera(pnl);
        }
    }
}
