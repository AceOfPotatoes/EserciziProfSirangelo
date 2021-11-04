using System.Windows.Forms;

namespace _26___Prodotti__penne
{
    abstract class Prodotto
    {
        public int Codice;
        public string Descrizione;
        public int PrezzoDiListino;

        public Prodotto(int NuovoCodice, string NuovaDescrizione, int NuovoPrezzoDiListino)
        {
            Codice = NuovoCodice;
            Descrizione = NuovaDescrizione;
            PrezzoDiListino = NuovoPrezzoDiListino;
        }
        public abstract void VisualizzaValoriForm(Label lbl1, Label lbl2, Label lbl3, Label lbl4, Label lbl5, Label lbl6, Label lbl7);
    }
}
