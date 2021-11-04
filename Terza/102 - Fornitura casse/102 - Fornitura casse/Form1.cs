using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _102___Fornitura_casse
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        int[] Pesi;
        int[] NumeroCasse;
        int NumPesi = 0;
        int NumCasse = 0;
        int SommaFornitura;
        bool Terminato;
        
        private void frmAvvio_Load(object sender, EventArgs e)
        {
            int Max = 100;
            Pesi = new int[Max];
            NumeroCasse = new int[Max];
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            if (Terminato)
            {
                MessageBox.Show("Hai già terminato l'aggiunta della fornitura!!!", "ATTENZIONE");
            }
            else
            {
                int Peso = Convert.ToInt16(txtCassa.Text);
                int Controllo = 0;

                for (int K = 0; K <= NumPesi - 1; K++)
                {
                    if (Peso == Pesi[K])
                    {
                        NumeroCasse[K]++;
                        SommaFornitura += Peso;
                        break;
                    }
                    Controllo++;
                }
                if (Controllo == NumPesi)
                {
                    Pesi[NumPesi] = Peso;
                    NumPesi++;
                    NumeroCasse[NumCasse]++;
                    NumCasse++;
                    SommaFornitura += Peso;
                }
                txtCassa.Text = "";
                txtCassa.Focus();
            }
            
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            if (Terminato)
            {
                MessageBox.Show("Hai già visualizzato l'aggiunta della fornitura!!!", "ATTENZIONE");
            }
            else
            {
                for (int K = 0; K <= NumPesi - 1; K++)
                {
                    lstPesi.Items.Add(Pesi[K]);
                }

                for (int K = 0; K <= NumCasse - 1; K++)
                {
                    lstCasse.Items.Add(NumeroCasse[K]);
                }
            }

            Terminato = true;
        }

        private void plsPeso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il peso complessivo della fornitura è di: " +SommaFornitura.ToString() + "kg");
        }
    }
}
