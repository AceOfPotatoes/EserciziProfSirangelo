using System.Windows.Forms;

namespace _26___Prodotti__penne
{
    class Penna : Prodotto
    {
        public string Colore;
        public bool èScatto;
        private int _ScontoScatto;
        private int NumPenne;

        public int ScontoScatto
        {
            get { return _ScontoScatto; }
            set
            {
                if (value > 0 && value < 100)
                    _ScontoScatto = PrezzoDiListino*value/100;
            }
        }

        public int NumeroPenne
        {
            get { return NumPenne; }
            set
            {
                if (NumPenne >= 0)
                    NumPenne = value;
            }
        }

        public Penna(int NuovoCodice, string NuovaDescrizione, int NuovoPrezzoDiListino, string NuovoColore, bool NuovoèScatto, int NuovoNumeroPenne) : base(NuovoCodice, NuovaDescrizione, NuovoPrezzoDiListino)
        {
            Colore = NuovoColore;
            èScatto = NuovoèScatto;
            NumeroPenne = NuovoNumeroPenne;
            ScontoScatto = 0;
        }

        public double PrezzoSingolaPenna()
        {
            return ((double)PrezzoDiListino / NumeroPenne) - ((double)ScontoScatto / NumeroPenne);
        }

        public override void VisualizzaValoriForm(Label lblCodice, Label lblPrezzoDiListino, Label lblScatto, Label lblColore, Label lblNumeroPenne, Label lblPrezzoSingolaPenna, Label lblDescrizione)
        {
            lblCodice.Text = Codice.ToString();
            lblPrezzoDiListino.Text = PrezzoDiListino.ToString();
            if (èScatto)
            {
                lblScatto.Text = "SI";
                
            }
            else
            {
                lblScatto.Text = "NO";
            }                
            lblColore.Text = Colore;
            lblNumeroPenne.Text = NumeroPenne.ToString();
            lblPrezzoSingolaPenna.Text = PrezzoSingolaPenna().ToString() + "€";
            lblDescrizione.Text = Descrizione;
        }
    }
}
