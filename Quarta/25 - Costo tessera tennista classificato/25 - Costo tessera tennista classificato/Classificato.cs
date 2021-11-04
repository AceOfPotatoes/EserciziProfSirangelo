using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25___Costo_tessera_tennista_classificato
{
    class Classificato : Tennista
    {
        public int Categoria;
        public int NumeroIscrizione;

        public Classificato(string NuovoNominativo, bool NuovaPreferenzaManuale, string NuovaRegione, int NuovaCategoria, int NuovoNumeroIscrizione) : base(NuovoNominativo, NuovaPreferenzaManuale, NuovaRegione)
        {
            Categoria = NuovaCategoria;
            NumeroIscrizione = NuovoNumeroIscrizione;
        }

        public override void VisualizzaDatiTennista(Label lblNome, Label lblRegione, Label lblPrefMan, Label lblCat, Label lblIscr)
        {
            base.VisualizzaDatiTennista(lblNome, lblRegione, lblPrefMan, lblCat, lblIscr);
            lblCat.Text = Categoria.ToString();
            lblIscr.Text = NumeroIscrizione.ToString();
        }

        public override void CalcolaEVisualizzaContributo(Label lblContributo)
        {
            if (miaRegione.RestituisciMacroarea(miaRegione.IndReg) == "NORD")
                lblContributo.Text = "100€";
            else if (miaRegione.RestituisciMacroarea(miaRegione.IndReg) == "CENTRO")
                lblContributo.Text = (100 - 10).ToString() + "€";
            else if (miaRegione.RestituisciMacroarea(miaRegione.IndReg) == "SUD")
                lblContributo.Text = (100 - 20).ToString() + "€";
            else
                lblContributo.Text = (100 - 30).ToString() + "€";
        }
    }
}
