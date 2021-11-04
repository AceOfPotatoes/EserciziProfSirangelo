using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34___Conto_corrente_bancario
{
    class ContoCorrente
    {
        public ContoCorrente() { }
  
        
        public List<int> Movimenti = new List<int>();
        
        public event EventHandler SottoZero;
        public event EventHandler SopraCentomila;

        public void EffettuaVersamento(int Versamento)
        {
            Movimenti.Add(Versamento);

            if (CalcolaSaldo() > 100000)
                SopraCentomila(this, new EventArgs());                
        }

        public void EffettuaPrelievo(int Prelievo)
        {
            Movimenti.Add(-Prelievo);

            if (CalcolaSaldo() < 0)
                SottoZero(this, new EventArgs());
        }

        public void EffettuaPrelievoSottoZero()
        {
            Movimenti.Add(-10);
        }

        public void EffettuaVersamentoSopraCentomila(int Versamento)
        {
            Movimenti.Add(Versamento / 100);
        }

        private int CalcolaSaldo()
        {
            int Saldo = 0;

            for (int k = 0; k < Movimenti.Count; k++)
                Saldo += Movimenti[k];

            return Saldo;
        }

        public void VisualizzaMovimenti(ListBox lstMovimenti)
        {
            lstMovimenti.Items.Clear();
            for (int k = 0; k < Movimenti.Count; k++)
                lstMovimenti.Items.Add(Movimenti[k]);                
        }

        public void VisualizzaSaldo(Label lblSaldo)
        {
            lblSaldo.Text = CalcolaSaldo().ToString();
        }
    }
}
