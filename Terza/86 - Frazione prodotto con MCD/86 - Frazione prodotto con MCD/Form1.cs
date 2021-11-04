using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _86___MCD_con_metodo_di_Euclide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            int N1 = Convert.ToInt32(txtN1.Text);           //Primo numeratore
            int D1 = Convert.ToInt32(txtD1.Text);           //Primo denominatore
            int N2 = Convert.ToInt32(txtN2.Text);           //Secondo numeratore
            int D2 = Convert.ToInt32(txtD2.Text);           //Secondo denominatore
            int MCD1 = MCD(N1, D1);                         //Tramite la funzione metto in MCD1 il MCD della prima frazione
            int MCD2 = MCD(N2, D2);                         //Tramite la funzione metto in MCD2 il MCD della seconda frazione
            int MCDFin;                                     //MCD della prima versione della frazione prodotto
            int NumFin;                                     //Numeratore finale della frazione prodotto
            int DenFin;                                     //Denominatore finale della frazione prodotto

            if(D1 == 0 || D2 == 0)            
                MessageBox.Show("IMPOSSIBILE AVERE DETERMINATORE UGUALE A 0", "ERRORE");
            
            else
            {
                //Divido tutti i membri delle due frazioni per i MCD corrispondenti
                N1 = N1 / MCD1;
                N2 = N2 / MCD2;
                D1 = D1 / MCD1;
                D2 = D2 / MCD2;

                //Assegno a MCDFin il MCD della prima versione della frazione prodotto e assegno i valori finali a num e den.
                MCDFin = MCD(N1 * N2, D1 * D2);
                NumFin = (N1 * N2) / MCDFin;
                DenFin = (D1 * D2) / MCDFin;

                lblN.Text = (NumFin).ToString();
                lblD.Text = (DenFin).ToString();
            }        
        }

        private int MCD(int X, int Y)
        {
            int Resto;

            while (Y != 0)
            {
                Resto = X % Y;
                X = Y;
                Y = Resto;
            }
            return X;
        }
    }
}
