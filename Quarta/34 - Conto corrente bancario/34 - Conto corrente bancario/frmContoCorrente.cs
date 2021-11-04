using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34___Conto_corrente_bancario
{
    public partial class frmContoCorrente : Form
    {
        public frmContoCorrente()
        {
            InitializeComponent();
        }

        ContoCorrente mioContoCorrente;

        private void GestisciSottoZero(object sender, EventArgs e)
        {
            mioContoCorrente.EffettuaPrelievoSottoZero();
            Visualizza();
        }

        private void GestisciSopraCentomila(object sender, EventArgs e)
        {
            mioContoCorrente.EffettuaVersamentoSopraCentomila(mioContoCorrente.Movimenti[mioContoCorrente.Movimenti.Count - 1]);
            Visualizza();
        }

        private void frmContoCorrente_Load(object sender, EventArgs e)
        {
            mioContoCorrente = new ContoCorrente();
            mioContoCorrente.SottoZero += GestisciSottoZero;
            mioContoCorrente.SopraCentomila += GestisciSopraCentomila;
        }

        private void plsPrelievo_Click(object sender, EventArgs e)
        {
            int Prelievo = (int)numCifra.Value;
            mioContoCorrente.EffettuaPrelievo(Prelievo);
            Visualizza();            
        }

        private void plsVersamento_Click(object sender, EventArgs e)
        {
            int Versamento = (int)numCifra.Value;
            mioContoCorrente.EffettuaVersamento(Versamento);
            mioContoCorrente.VisualizzaMovimenti(lstMovimenti);
            Visualizza();
        }

        private void Visualizza()
        {
            mioContoCorrente.VisualizzaMovimenti(lstMovimenti);
            mioContoCorrente.VisualizzaSaldo(lblSaldo);
        }
    }
}
