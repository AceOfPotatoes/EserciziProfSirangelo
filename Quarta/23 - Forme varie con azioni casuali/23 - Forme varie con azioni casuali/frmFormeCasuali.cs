using System;
using System.Windows.Forms;

namespace _23___Forme_varie_con_azioni_casuali
{
    public partial class frmFormeCasuali : Form
    {
        public frmFormeCasuali()
        {
            InitializeComponent();
        }
        int NumeroTick;
        FiguraGrafica mieFigure;
              
        private void frmFormeCasuali_Load(object sender, EventArgs e)
        {
            mieFigure = new FiguraGrafica();
            tmrDisegno.Start();
            tmrCasuali.Start();
        }

        private void tmrDisegno_Tick(object sender, EventArgs e)
        {
            if(mieFigure.ListaFigure.Count != 0)
                for(int k = 0; k<mieFigure.ListaFigure.Count; k++)
                {
                    mieFigure.ListaFigure[k].Muovi(Pannello);

                    if (mieFigure.ListaFigure[k].Fuori(Pannello))
                    {
                        mieFigure.ListaFigure[k].InvertiDirezione(Pannello);                       
                    }
                                             
                }           
        }

      private void tmrCasuali_Tick(object sender, EventArgs e)
      {
            NumeroTick++;

            if (NumeroTick != tmrCasuali.Interval)
            {
                for (int k = NumeroTick%2; k < mieFigure.ListaFigure.Count; k+=2)
                {
                    mieFigure.ListaFigure[k].CambiaDimensione(Pannello);
                    mieFigure.ListaFigure[k].CambiaVelocità();
                    mieFigure.ListaFigure[k].CambiaDirezione();
                }
                if (tmrCasuali.Interval > 500 && tmrCasuali.Interval < 2000)
                    tmrCasuali.Interval += mieFigure.R.Next(-200, +200);
                else if (tmrCasuali.Interval < 500)
                    tmrCasuali.Interval += mieFigure.R.Next(200);
                else
                    tmrCasuali.Interval += mieFigure.R.Next(-200, 0);
            }
            else
                NumeroTick = 0;
            
       }
        
        private void frmFormeCasuali_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                mieFigure.CreaFigura();
        }
    }
}
